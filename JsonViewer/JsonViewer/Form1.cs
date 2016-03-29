using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using jhTreeViewTools;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace JsonViewer
{
    public partial class form : Form
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        LoadAndSave lsTree = new LoadAndSave();
        rName nrname = new rName();
        private const string XmlNodeTextAtt1 = "name";
        private const string XmlNodeTextAtt2 = "value";
        private const string XmlNodeTagAtt = "tag";
        private const string XmlNodeImageIndexAtt = "imageindex";
        private const string XmlNodeTag = "node";
        private exportXML exml = new exportXML();
        private TreeNode copyNode;



        public form()
        {

            InitializeComponent();
            jsonExplorer.ItemDrag += new ItemDragEventHandler(treeView1_ItemDrag);
            jsonExplorer.DragEnter += new DragEventHandler(treeView1_DragEnter);
            jsonExplorer.DragOver += new DragEventHandler(treeView1_DragOver);
            jsonExplorer.DragDrop += new DragEventHandler(treeView1_DragDrop);
            jsonExplorer.MouseDown += (sender, args) =>
                 jsonExplorer.SelectedNode = jsonExplorer.GetNodeAt(args.X, args.Y);
          
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                Deserialize();
            }
            else
            {
                MessageBox.Show("Please enter some JSON data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void BuildTree(Dictionary<string, object> dictionary, TreeNode node)
        {
            foreach (KeyValuePair<string, object> item in dictionary)
            {
                var parentNode = new TreeNode(item.Key);
                node.Nodes.Add(parentNode);

                try
                {
                    dictionary = (Dictionary<string, object>)item.Value;
                    BuildTree(dictionary, parentNode);
                }
                catch (InvalidCastException dicE)
                {
                    try
                    {
                        var list = (ArrayList)item.Value;
                        foreach (string value in list)
                        {
                            var finalNode = new TreeNode(value);
                            finalNode.ForeColor = Color.Blue;
                            parentNode.Nodes.Add(finalNode);
                        }


                    }
                    catch (InvalidCastException ex)
                    {
                        var finalNode = new TreeNode(item.Value.ToString());
                        finalNode.ForeColor = Color.Red;
                        parentNode.Text = parentNode.Text + ": " + finalNode.Text;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofDialog = new OpenFileDialog();
            ofDialog.Filter = "Tree (*.tree)|*.tree";
            ofDialog.ShowDialog();

            LoadAndSave.loadTree(jsonExplorer, ofDialog.FileName);

        }

        private void Deserialize()
        {
            jsonExplorer.Nodes.Clear();

            try
            {
                Dictionary<string, object> dic = js.Deserialize<Dictionary<string, object>>(txtInput.Text);

                var rootNode = new TreeNode("Root");
                jsonExplorer.Nodes.Add(rootNode);
                BuildTree(dic, rootNode);
            }
            catch (ArgumentException argE)
            {
                MessageBox.Show("JSON data is not valid\n\r" + argE.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void addChildClick(object sender, EventArgs e)
        {
            if (jsonExplorer.SelectedNode != null && textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                string yourChildNode;
                yourChildNode = textBox1.Text.Trim() + ":" + textBox2.Text.Trim();
                jsonExplorer.SelectedNode.Nodes.Add(yourChildNode);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        void ImprtJSONToolStripMenuItemClick(object sender, EventArgs e)
        {
            var ofDialog = new OpenFileDialog();
             ofDialog.Filter = "JSON (*.json)|*.json";
            ofDialog.ShowDialog();

            try
            {
                using (var fileReader = new StreamReader(ofDialog.FileName))
                {
                    txtInput.Text = fileReader.ReadToEnd();
                    Deserialize();
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Unable to open the file. " + ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Tree (*.tree)|*.tree";
            saveFile.ShowDialog();
            LoadAndSave.saveTree(jsonExplorer, saveFile.FileName);
        }

        void AddNodeClick(object sender, EventArgs e)
        {
            if (jsonExplorer.SelectedNode != null && textBox3.Text.Length > 0)
            {
                string yourChildNode;
                yourChildNode = textBox3.Text.Trim();
                jsonExplorer.SelectedNode.Nodes.Add(yourChildNode);
                textBox3.Text = "";
            }
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Move the dragged node when the left mouse button is used. 
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }

            // Copy the dragged node when the right mouse button is used. 
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse position.
            Point targetPoint = jsonExplorer.PointToClient(new Point(e.X, e.Y));

            // Select the node at the mouse position.
            jsonExplorer.SelectedNode = jsonExplorer.GetNodeAt(targetPoint);
        }
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = jsonExplorer.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = jsonExplorer.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Confirm that the node at the drop location is not  
            // the dragged node or a descendant of the dragged node. 
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                // If it is a move operation, remove the node from its current  
                // location and add it to the node at the drop location. 
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                // If it is a copy operation, clone the dragged node  
                // and add it to the node at the drop location. 
                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                }

                // Expand the node at the location  
                // to show the dropped node.
                targetNode.Expand();
            }
        }
        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            // Check the parent node of the second node. 
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;       



            // If the parent node is not null or equal to the first node,  
            // call the ContainsNode method recursively using the parent of  
            // the second node. 
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonExplorer.SelectedNode != null)
            {

                string s;

                if (rName.Get("Enter Room Name","",out s))
                {
                    var tn=new TreeNode(s);
                    tn.Nodes.Add("Audio");
                    tn.Nodes.Add("Control");
                    tn.Nodes.Add("Video");
                    jsonExplorer.SelectedNode.Nodes.Add(tn);
                    jsonExplorer.SelectedNode.Expand();
                }

            }


        }

        private void addControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonExplorer.SelectedNode != null)
            {
                var tn = new TreeNode("Device");
                tn.Nodes.Add("Brand:");
                tn.Nodes.Add("Model:");
                tn.Nodes.Add("SN:");
                tn.Nodes.Add("IP:");
                tn.Nodes.Add("Location:");
                tn.Nodes.Add("Tag:");
                jsonExplorer.SelectedNode.Nodes.Add(tn);
                jsonExplorer.SelectedNode.Expand();
            }
        }

        private void addMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonExplorer.SelectedNode != null)
            {
                var tn = new TreeNode("Device");
                var ti = new TreeNode("Inputs");
                for (int i = 1; i < 17; i++) ti.Nodes.Add("Input " + i.ToString() + ":");
                var to = new TreeNode("Outputs");
                for (int i = 1; i < 17; i++) to.Nodes.Add("Output " + i.ToString() + ":");
                tn.Nodes.Add("Brand:");
                tn.Nodes.Add("Model:");
                tn.Nodes.Add("SN:");
                tn.Nodes.Add("IP:");
                tn.Nodes.Add("Location:");
                tn.Nodes.Add("Tag:");
                tn.Nodes.Add(ti);
                tn.Nodes.Add(to);
                jsonExplorer.SelectedNode.Nodes.Add(tn);
                jsonExplorer.SelectedNode.Expand();
            }
        }

        private void добавитьСистемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 string s;

                if (rName.Get("Enter Folder Name","",out s))
                {
                    var tn=new TreeNode(s);
                    tn.Tag = "Folder";
                    jsonExplorer.SelectedNode.Nodes.Add(tn);
                    jsonExplorer.SelectedNode.Expand();
                }

            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonExplorer.SelectedNode != null)  jsonExplorer.SelectedNode.Remove();
        }

        private void jsonExplorer_DoubleClick(object sender, EventArgs e)
        {
            string s;
            if (jsonExplorer.SelectedNode == null) return;
            if (jsonExplorer.SelectedNode.Nodes.Count>0)
                if (rName.Get("Edit...", jsonExplorer.SelectedNode.Text, out s))
                {

                    jsonExplorer.SelectedNode.Text=s;
       
                }

             if (jsonExplorer.SelectedNode.Nodes.Count==0)
             {
                 if (childEdit.Get(jsonExplorer.SelectedNode.Text,out s))
                 {
                     jsonExplorer.SelectedNode.Text = s;
                 }
             }
        }

        private void exportToJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exml.exportToXML(jsonExplorer);
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s;
            if (jsonExplorer.SelectedNode.Nodes.Count > 0)
            {
                if (childEdit.Get(":", out s))
                {
                    
                    jsonExplorer.SelectedNode.Nodes.Add(s);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyNode =(TreeNode) jsonExplorer.SelectedNode.Clone();
            Clipboard.SetData("sel",jsonExplorer.SelectedNode); 
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tn = jsonExplorer.SelectedNode;
            tn.Nodes.Add(copyNode);
            //jsonExplorer.SelectedNode. Nodes.Insert(jsonExplorer.SelectedNode.Index, copyNode);
        }



        
        void ExportToHTMLToolStripMenuItemClick(object sender, EventArgs e)
        {
        	if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"\\dtree.zip"))
        	try{
				using (var client = new System.Net.WebClient())
				{
				    client.DownloadFile("http://maxrg.ru/dtree.zip", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"\\dtree.zip");
				}
        	}
        	// disable once EmptyGeneralCatchClause
        	catch
        	{}
        	
			exml.SaveNodesHTML(jsonExplorer);
        }
    }
}