using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace JsonViewer
{
    class exportXML
    {
        private const string XmlNodeTextAtt1 = "name";
        private const string XmlNodeTextAtt2 = "value";
        private const string XmlNodeTagAtt = "tag";
        private const string XmlNodeImageIndexAtt = "imageindex";
        private const string XmlNodeTag = "node";
        private int icounter;
        private int[] icurrent=new int[20];
        private int index=0;
        private string startstring,endstring;

        public exportXML()
        {
		icounter=0;
		icurrent[0]=-1;
		startstring="<!DOCTYPE html PUBLIC\"-//W3C//DTD XHTML 1.0 Strict//EN\"\\ \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"><html><head>"+
	"<title>Project</title>   	<meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />"+
	"<link rel=\"StyleSheet\" href=\"dtree.css\" type=\"text/css\" /><script type=\"text/javascript\" src=\"dtree.js\"></script></head><body><div class=\"dtree\">"+
	"<p><a href=\"javascript: d.openAll();\">open all</a> | <a href=\"javascript: d.closeAll();\">close all</a></p>"+
	"<script type=\"text/javascript\">	d = new dTree('d');";
		endstring="document.write(d);	</script></div></body></html>";
        }

        public void exportToXML(TreeView jsonExplorer)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "XML (*.xml)|*.xml";
            saveFile.ShowDialog();
            SerializeTreeView(jsonExplorer, saveFile.FileName);

        }

        private void SerializeTreeView(TreeView treeView, string fileName)
        {
            var textWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("TreeView");
            SaveNodes(treeView.Nodes, textWriter);
            textWriter.WriteEndElement();
            textWriter.Close();

            var file = new System.IO.StreamWriter("C:\\Users\\MaxRG\\Downloads\\fancytree-master\\fancytree-master\\test\\test.html");
            file.WriteLine("<!DOCTYPE html><html><head>  <meta http-equiv=\"content-type\" content=\"text/html; charset=utf-8\"> <title>Fancytree - Example</title>");
            file.WriteLine("<script src=\"../lib/jquery.js\" type=\"text/javascript\"></script>  <script src=\"../lib/jquery-ui.custom.js\" type=\"text/javascript\"></script>");
            file.WriteLine("<link href=\"../src/skin-lion/ui.fancytree.css\" rel=\"stylesheet\" type=\"text/css\"> <script src=\"../src/jquery.fancytree.js\" type=\"text/javascript\"></script>");
            file.WriteLine("  <script type=\"text/javascript\">$(function(){$(\"#tree\").fancytree(); }); </script>");
            file.WriteLine("</head><body class=\"example\"> <h1>Example: Default</h1><div id=\"tree\">  <ul id=\"treeData\" style=\"display: none;\">");

            SaveNodesJson(treeView.Nodes,file);
            file.WriteLine("</ul></div></body></html>");
            file.Close();
            
     

     
        }

        private void SaveNodes(TreeNodeCollection nodesCollection, XmlTextWriter textWriter)
        {
			for (int i = 0; i < nodesCollection.Count; i++) {
				var node = nodesCollection[i];
				textWriter.WriteStartElement(XmlNodeTag);
				if (node.Text.IndexOf(':') > 0) {
					textWriter.WriteAttributeString(XmlNodeTextAtt1, node.Text.Split(':')[0]);
					textWriter.WriteAttributeString(XmlNodeTextAtt2, node.Text.Split(':')[1].TrimStart());
				} else
					textWriter.WriteAttributeString(XmlNodeTextAtt1, node.Text);
				if (node.Tag != null)
					textWriter.WriteAttributeString(XmlNodeTagAtt, node.Tag.ToString());
				if (node.Nodes.Count > 0) {
					SaveNodes(node.Nodes, textWriter);
				}
				textWriter.WriteEndElement();
			}
        }

        private void SaveNodesJson(TreeNodeCollection nodesCollection, System.IO.StreamWriter file)
        {

			for (int i = 0; i < nodesCollection.Count; i++) {
				var node = nodesCollection[i];
				if (node.Nodes.Count > 0) {
					file.WriteLine("<li class=\"folder\">{0}", node.Text);
					file.Write("<ul>");
					SaveNodesJson(node.Nodes, file);
					file.Write("</ul>");
				} else {
					file.Write("<li>{0}", node.Text);
				}
			}



        }

        
        public void SaveNodesHTML  (TreeView treeView){
        	
    	  var fbd=new FolderBrowserDialog();
 
    	  fbd.ShowDialog();
    	  string html_dir=fbd.SelectedPath+"\\html";
    	  DirectoryInfo di=Directory.CreateDirectory(html_dir);
		var file = new System.IO.StreamWriter(html_dir+"\\index.html");        	
		file.WriteLine(startstring);
		SaveNodesDTree(treeView.Nodes,file);
		file.WriteLine(endstring);
		file.Close();
        }
        
        
        private void SaveNodesDTree(TreeNodeCollection nodesCollection, System.IO.StreamWriter file){
			for (int i = 0; i < nodesCollection.Count; i++) {
				var node = nodesCollection[i];
				file.WriteLine("d.add({0},{1},\'{2}\')", icounter, icurrent[index], node.Text);
				icounter++;
				if (node.Nodes.Count > 0) {
					index++;
					icurrent[index] = icounter - 1;
					SaveNodesDTree(node.Nodes, file);
					index--;
				}
			}         
        }
    }
}
