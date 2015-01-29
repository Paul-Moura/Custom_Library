using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.Radiography
{
    partial class InspectionResults
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = SystemColors.Control;
            this.panel1.Controls.Add((Control)this.label1);
            this.panel1.Controls.Add((Control)this.button1);
            this.panel1.Controls.Add((Control)this.comboBox1);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(695, 21);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = SystemColors.ControlDark;
            this.label1.Dock = DockStyle.Fill;
            this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label1.Location = new Point(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(455, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inspection Results";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = DockStyle.Left;
            this.button1.Location = new Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert Image(s)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = DockStyle.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[5]
            {
                (object) "Details",
                (object) "Large Icons",
                (object) "List",
                (object) "Small Icons",
                (object) "Tile"
            });
            this.comboBox1.Location = new Point(575, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(120, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.ilLarge;
            this.listView1.Location = new Point(0, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(695, 398);
            this.listView1.SmallImageList = this.ilSmall;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DragDrop += new DragEventHandler(this.listView1_DragDrop);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
            {
                (ToolStripItem) this.viewToolStripMenuItem,
                (ToolStripItem) this.toolStripSeparator1,
                (ToolStripItem) this.addImagesToolStripMenuItem,
                (ToolStripItem) this.deleteToolStripMenuItem
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(146, 76);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
            {
                (ToolStripItem) this.detailsToolStripMenuItem,
                (ToolStripItem) this.largeIconsToolStripMenuItem,
                (ToolStripItem) this.listToolStripMenuItem,
                (ToolStripItem) this.smallIconsToolStripMenuItem,
                (ToolStripItem) this.tileToolStripMenuItem
            });
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new Size(145, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new Size(134, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new Size(134, 22);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new Size(134, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new Size(134, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new Size(134, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(142, 6);
            // 
            // addImagesToolStripMenuItem
            // 
            this.addImagesToolStripMenuItem.Name = "addImagesToolStripMenuItem";
            this.addImagesToolStripMenuItem.Size = new Size(145, 22);
            this.addImagesToolStripMenuItem.Text = "Add Image(s)";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // ilLarge
            // 
            this.ilLarge.ColorDepth = ColorDepth.Depth32Bit;
            this.ilLarge.ImageSize = new Size(40, 40);
            this.ilLarge.TransparentColor = Color.Transparent;
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = ColorDepth.Depth8Bit;
            this.ilSmall.ImageSize = new Size(16, 16);
            this.ilSmall.TransparentColor = Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Dock = DockStyle.Bottom;
            this.textBox1.Location = new Point(0, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(695, 100);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = SystemColors.ControlDark;
            this.label2.Dock = DockStyle.Bottom;
            this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label2.Location = new Point(0, 298);
            this.label2.Name = "label2";
            this.label2.Size = new Size(695, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comments";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InspectionsResults
            // 
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.listView1);
            this.Controls.Add((Control)this.panel1);
            this.Name = "InspectionResults";
            this.Size = new Size(695, 419);
            this.Load += new EventHandler(this.InspectionResults_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private ListView listView1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private ImageList ilSmall;
        private ImageList ilLarge;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem largeIconsToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem smallIconsToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addImagesToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
