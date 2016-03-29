namespace JsonViewer
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.menuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
        	this.imprtJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exportToJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exportToHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.splitContainer = new System.Windows.Forms.SplitContainer();
        	this.jsonExplorer = new System.Windows.Forms.TreeView();
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.добавитьСистемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
        	this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
        	this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.txtInput = new System.Windows.Forms.RichTextBox();
        	this.panel = new System.Windows.Forms.Panel();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.addNode = new System.Windows.Forms.Button();
        	this.textBox3 = new System.Windows.Forms.TextBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.addChild = new System.Windows.Forms.Button();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.btnDeserialize = new System.Windows.Forms.Button();
        	this.menuStrip.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
        	this.splitContainer.Panel1.SuspendLayout();
        	this.splitContainer.Panel2.SuspendLayout();
        	this.splitContainer.SuspendLayout();
        	this.contextMenuStrip1.SuspendLayout();
        	this.panel.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip
        	// 
        	this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem});
        	this.menuStrip.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip.Name = "menuStrip";
        	this.menuStrip.Size = new System.Drawing.Size(786, 24);
        	this.menuStrip.TabIndex = 3;
        	this.menuStrip.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.openToolStripMenuItem,
        	        	        	this.saveToolStripMenuItem,
        	        	        	this.toolStripMenuItem1,
        	        	        	this.imprtJSONToolStripMenuItem,
        	        	        	this.exportToJSONToolStripMenuItem,
        	        	        	this.exportToHTMLToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "File";
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
        	this.openToolStripMenuItem.Text = "Open";
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
        	this.saveToolStripMenuItem.Text = "Save";
        	this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
        	// 
        	// toolStripMenuItem1
        	// 
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
        	// 
        	// imprtJSONToolStripMenuItem
        	// 
        	this.imprtJSONToolStripMenuItem.Name = "imprtJSONToolStripMenuItem";
        	this.imprtJSONToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
        	this.imprtJSONToolStripMenuItem.Text = "Imprt from JSON";
        	this.imprtJSONToolStripMenuItem.Click += new System.EventHandler(this.ImprtJSONToolStripMenuItemClick);
        	// 
        	// exportToJSONToolStripMenuItem
        	// 
        	this.exportToJSONToolStripMenuItem.Name = "exportToJSONToolStripMenuItem";
        	this.exportToJSONToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
        	this.exportToJSONToolStripMenuItem.Text = "Export to XML";
        	this.exportToJSONToolStripMenuItem.Click += new System.EventHandler(this.exportToJSONToolStripMenuItem_Click);
        	// 
        	// exportToHTMLToolStripMenuItem
        	// 
        	this.exportToHTMLToolStripMenuItem.Name = "exportToHTMLToolStripMenuItem";
        	this.exportToHTMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
        	this.exportToHTMLToolStripMenuItem.Text = "Export to HTML";
        	this.exportToHTMLToolStripMenuItem.Click += new System.EventHandler(this.ExportToHTMLToolStripMenuItemClick);
        	// 
        	// splitContainer
        	// 
        	this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer.Location = new System.Drawing.Point(0, 24);
        	this.splitContainer.Name = "splitContainer";
        	// 
        	// splitContainer.Panel1
        	// 
        	this.splitContainer.Panel1.Controls.Add(this.jsonExplorer);
        	// 
        	// splitContainer.Panel2
        	// 
        	this.splitContainer.Panel2.Controls.Add(this.txtInput);
        	this.splitContainer.Panel2.Controls.Add(this.panel);
        	this.splitContainer.Size = new System.Drawing.Size(786, 402);
        	this.splitContainer.SplitterDistance = 448;
        	this.splitContainer.TabIndex = 4;
        	// 
        	// jsonExplorer
        	// 
        	this.jsonExplorer.AllowDrop = true;
        	this.jsonExplorer.ContextMenuStrip = this.contextMenuStrip1;
        	this.jsonExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.jsonExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.jsonExplorer.Indent = 20;
        	this.jsonExplorer.Location = new System.Drawing.Point(0, 0);
        	this.jsonExplorer.Name = "jsonExplorer";
        	this.jsonExplorer.Size = new System.Drawing.Size(448, 402);
        	this.jsonExplorer.TabIndex = 0;
        	this.jsonExplorer.DoubleClick += new System.EventHandler(this.jsonExplorer_DoubleClick);
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.addRoomToolStripMenuItem,
        	        	        	this.addDeviceToolStripMenuItem,
        	        	        	this.добавитьСистемуToolStripMenuItem,
        	        	        	this.addItemToolStripMenuItem,
        	        	        	this.toolStripMenuItem3,
        	        	        	this.editToolStripMenuItem,
        	        	        	this.deleteToolStripMenuItem,
        	        	        	this.toolStripMenuItem2,
        	        	        	this.copyToolStripMenuItem,
        	        	        	this.pasteToolStripMenuItem});
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.Size = new System.Drawing.Size(142, 192);
        	// 
        	// addRoomToolStripMenuItem
        	// 
        	this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
        	this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.addRoomToolStripMenuItem.Text = "Add Room";
        	this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
        	// 
        	// addDeviceToolStripMenuItem
        	// 
        	this.addDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.addControlToolStripMenuItem,
        	        	        	this.addMatrixToolStripMenuItem});
        	this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
        	this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.addDeviceToolStripMenuItem.Text = "Add Device";
        	// 
        	// addControlToolStripMenuItem
        	// 
        	this.addControlToolStripMenuItem.Name = "addControlToolStripMenuItem";
        	this.addControlToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.addControlToolStripMenuItem.Text = "Custom Device";
        	this.addControlToolStripMenuItem.Click += new System.EventHandler(this.addControlToolStripMenuItem_Click);
        	// 
        	// addMatrixToolStripMenuItem
        	// 
        	this.addMatrixToolStripMenuItem.Name = "addMatrixToolStripMenuItem";
        	this.addMatrixToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.addMatrixToolStripMenuItem.Text = "Matrix";
        	this.addMatrixToolStripMenuItem.Click += new System.EventHandler(this.addMatrixToolStripMenuItem_Click);
        	// 
        	// добавитьСистемуToolStripMenuItem
        	// 
        	this.добавитьСистемуToolStripMenuItem.Name = "добавитьСистемуToolStripMenuItem";
        	this.добавитьСистемуToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.добавитьСистемуToolStripMenuItem.Text = "Add Folder";
        	this.добавитьСистемуToolStripMenuItem.Click += new System.EventHandler(this.добавитьСистемуToolStripMenuItem_Click);
        	// 
        	// addItemToolStripMenuItem
        	// 
        	this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
        	this.addItemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.addItemToolStripMenuItem.Text = "Add Item";
        	this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem3
        	// 
        	this.toolStripMenuItem3.Name = "toolStripMenuItem3";
        	this.toolStripMenuItem3.Size = new System.Drawing.Size(138, 6);
        	// 
        	// editToolStripMenuItem
        	// 
        	this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        	this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
        	this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.editToolStripMenuItem.Text = "Edit";
        	this.editToolStripMenuItem.Click += new System.EventHandler(this.jsonExplorer_DoubleClick);
        	// 
        	// deleteToolStripMenuItem
        	// 
        	this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        	this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
        	this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.deleteToolStripMenuItem.Text = "Delete";
        	this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem2
        	// 
        	this.toolStripMenuItem2.Name = "toolStripMenuItem2";
        	this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
        	// 
        	// copyToolStripMenuItem
        	// 
        	this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        	this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        	this.copyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.copyToolStripMenuItem.Text = "Copy";
        	this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
        	// 
        	// pasteToolStripMenuItem
        	// 
        	this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        	this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
        	this.pasteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.pasteToolStripMenuItem.Text = "Paste";
        	this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
        	// 
        	// txtInput
        	// 
        	this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.txtInput.Location = new System.Drawing.Point(0, 0);
        	this.txtInput.Name = "txtInput";
        	this.txtInput.Size = new System.Drawing.Size(334, 67);
        	this.txtInput.TabIndex = 1;
        	this.txtInput.Text = "";
        	// 
        	// panel
        	// 
        	this.panel.Controls.Add(this.groupBox2);
        	this.panel.Controls.Add(this.groupBox1);
        	this.panel.Controls.Add(this.btnDeserialize);
        	this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.panel.Location = new System.Drawing.Point(0, 67);
        	this.panel.Name = "panel";
        	this.panel.Size = new System.Drawing.Size(334, 335);
        	this.panel.TabIndex = 0;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.addNode);
        	this.groupBox2.Controls.Add(this.textBox3);
        	this.groupBox2.Location = new System.Drawing.Point(3, 16);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(120, 106);
        	this.groupBox2.TabIndex = 7;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Папка";
        	// 
        	// addNode
        	// 
        	this.addNode.Location = new System.Drawing.Point(6, 71);
        	this.addNode.Name = "addNode";
        	this.addNode.Size = new System.Drawing.Size(100, 23);
        	this.addNode.TabIndex = 3;
        	this.addNode.Text = "Добавить";
        	this.addNode.UseVisualStyleBackColor = true;
        	this.addNode.Click += new System.EventHandler(this.AddNodeClick);
        	// 
        	// textBox3
        	// 
        	this.textBox3.Location = new System.Drawing.Point(6, 19);
        	this.textBox3.Name = "textBox3";
        	this.textBox3.Size = new System.Drawing.Size(100, 20);
        	this.textBox3.TabIndex = 4;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.addChild);
        	this.groupBox1.Controls.Add(this.textBox1);
        	this.groupBox1.Controls.Add(this.textBox2);
        	this.groupBox1.Location = new System.Drawing.Point(133, 16);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(120, 106);
        	this.groupBox1.TabIndex = 6;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Свойство";
        	// 
        	// addChild
        	// 
        	this.addChild.Location = new System.Drawing.Point(6, 71);
        	this.addChild.Name = "addChild";
        	this.addChild.Size = new System.Drawing.Size(100, 23);
        	this.addChild.TabIndex = 3;
        	this.addChild.Text = "Добавить";
        	this.addChild.UseVisualStyleBackColor = true;
        	this.addChild.Click += new System.EventHandler(this.addChildClick);
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(6, 19);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(100, 20);
        	this.textBox1.TabIndex = 4;
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(6, 45);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(100, 20);
        	this.textBox2.TabIndex = 5;
        	// 
        	// btnDeserialize
        	// 
        	this.btnDeserialize.Dock = System.Windows.Forms.DockStyle.Right;
        	this.btnDeserialize.Location = new System.Drawing.Point(259, 0);
        	this.btnDeserialize.Name = "btnDeserialize";
        	this.btnDeserialize.Size = new System.Drawing.Size(75, 335);
        	this.btnDeserialize.TabIndex = 0;
        	this.btnDeserialize.Text = "Deserialize";
        	this.btnDeserialize.UseVisualStyleBackColor = true;
        	this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
        	// 
        	// form
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(786, 426);
        	this.Controls.Add(this.splitContainer);
        	this.Controls.Add(this.menuStrip);
        	this.MainMenuStrip = this.menuStrip;
        	this.Name = "form";
        	this.Text = "Json Viewer";
        	this.menuStrip.ResumeLayout(false);
        	this.menuStrip.PerformLayout();
        	this.splitContainer.Panel1.ResumeLayout(false);
        	this.splitContainer.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
        	this.splitContainer.ResumeLayout(false);
        	this.contextMenuStrip1.ResumeLayout(false);
        	this.panel.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem exportToHTMLToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addNode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem exportToJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprtJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addChild;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView jsonExplorer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСистемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;


        

    }
}

