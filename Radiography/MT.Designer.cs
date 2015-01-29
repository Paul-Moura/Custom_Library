using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomControls.Radiography
{
    partial class MT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MT));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.inspectionResults1 = new CustomControls.Radiography.InspectionResults();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox7 = new CustomControls.AutoCompleteTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox8 = new CustomControls.AutoCompleteTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.autoCompleteTextBox4 = new CustomControls.AutoCompleteTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox5 = new CustomControls.AutoCompleteTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.autoCompleteTextBox3 = new CustomControls.AutoCompleteTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox2 = new CustomControls.AutoCompleteTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autoCompleteTextBox1 = new CustomControls.AutoCompleteTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.inspectionResults1);
            this.pnlMain.Controls.Add(this.panel11);
            this.pnlMain.Controls.Add(this.panel10);
            this.pnlMain.Controls.Add(this.panel9);
            this.pnlMain.Controls.Add(this.panel7);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(809, 599);
            this.pnlMain.TabIndex = 0;
            // 
            // inspectionResults1
            // 
            this.inspectionResults1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionResults1.ImagesDirectory = null;
            this.inspectionResults1.Location = new System.Drawing.Point(0, 248);
            this.inspectionResults1.Margin = new System.Windows.Forms.Padding(4);
            this.inspectionResults1.Name = "inspectionResults1";
            this.inspectionResults1.Size = new System.Drawing.Size(807, 349);
            this.inspectionResults1.TabIndex = 13;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dateTimePicker1);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.autoCompleteTextBox7);
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.autoCompleteTextBox8);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 217);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(4);
            this.panel11.Size = new System.Drawing.Size(807, 31);
            this.panel11.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(598, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Location = new System.Drawing.Point(512, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Cal. Due:";
            // 
            // autoCompleteTextBox7
            // 
            this.autoCompleteTextBox7.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox7.AutoCompleteList")));
            this.autoCompleteTextBox7.CaseSensitive = false;
            this.autoCompleteTextBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox7.Location = new System.Drawing.Point(362, 4);
            this.autoCompleteTextBox7.MaxDisplayedItems = 10;
            this.autoCompleteTextBox7.MinTypedCharacters = 3;
            this.autoCompleteTextBox7.Name = "autoCompleteTextBox7";
            this.autoCompleteTextBox7.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox7.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox7.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox7.SuggestionsFile = null;
            this.autoCompleteTextBox7.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Location = new System.Drawing.Point(292, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "Model:";
            // 
            // autoCompleteTextBox8
            // 
            this.autoCompleteTextBox8.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox8.AutoCompleteList")));
            this.autoCompleteTextBox8.CaseSensitive = false;
            this.autoCompleteTextBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox8.Location = new System.Drawing.Point(142, 4);
            this.autoCompleteTextBox8.MaxDisplayedItems = 10;
            this.autoCompleteTextBox8.MinTypedCharacters = 3;
            this.autoCompleteTextBox8.Name = "autoCompleteTextBox8";
            this.autoCompleteTextBox8.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox8.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox8.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox8.SuggestionsFile = null;
            this.autoCompleteTextBox8.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Location = new System.Drawing.Point(87, 4);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Mfg:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Location = new System.Drawing.Point(4, 4);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label18.Size = new System.Drawing.Size(83, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Light Meter:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.checkBox3);
            this.panel10.Controls.Add(this.checkBox2);
            this.panel10.Controls.Add(this.checkBox1);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 186);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(4);
            this.panel10.Size = new System.Drawing.Size(807, 31);
            this.panel10.TabIndex = 11;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox3.Location = new System.Drawing.Point(400, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.checkBox3.Size = new System.Drawing.Size(154, 23);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Outdoor Ambient";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox2.Location = new System.Drawing.Point(255, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(145, 23);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Ultraviolet Light";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox1.Location = new System.Drawing.Point(137, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(118, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "White Light";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(4, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label14.Size = new System.Drawing.Size(133, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lighting Equipment:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.autoCompleteTextBox4);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.comboBox5);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.autoCompleteTextBox5);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 155);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(4);
            this.panel9.Size = new System.Drawing.Size(807, 31);
            this.panel9.TabIndex = 10;
            // 
            // autoCompleteTextBox4
            // 
            this.autoCompleteTextBox4.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox4.AutoCompleteList")));
            this.autoCompleteTextBox4.CaseSensitive = false;
            this.autoCompleteTextBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox4.Location = new System.Drawing.Point(526, 4);
            this.autoCompleteTextBox4.MaxDisplayedItems = 10;
            this.autoCompleteTextBox4.MinTypedCharacters = 3;
            this.autoCompleteTextBox4.Name = "autoCompleteTextBox4";
            this.autoCompleteTextBox4.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox4.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox4.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox4.SuggestionsFile = null;
            this.autoCompleteTextBox4.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(446, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Batch #:";
            // 
            // comboBox5
            // 
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(346, 4);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 24);
            this.comboBox5.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(282, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Type:";
            // 
            // autoCompleteTextBox5
            // 
            this.autoCompleteTextBox5.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox5.AutoCompleteList")));
            this.autoCompleteTextBox5.CaseSensitive = false;
            this.autoCompleteTextBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox5.Location = new System.Drawing.Point(132, 4);
            this.autoCompleteTextBox5.MaxDisplayedItems = 10;
            this.autoCompleteTextBox5.MinTypedCharacters = 3;
            this.autoCompleteTextBox5.Name = "autoCompleteTextBox5";
            this.autoCompleteTextBox5.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox5.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox5.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox5.SuggestionsFile = null;
            this.autoCompleteTextBox5.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label13.Size = new System.Drawing.Size(128, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Contrast Paint Mfg:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.autoCompleteTextBox3);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.comboBox2);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.autoCompleteTextBox2);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 124);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(4);
            this.panel7.Size = new System.Drawing.Size(807, 31);
            this.panel7.TabIndex = 9;
            // 
            // autoCompleteTextBox3
            // 
            this.autoCompleteTextBox3.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox3.AutoCompleteList")));
            this.autoCompleteTextBox3.CaseSensitive = false;
            this.autoCompleteTextBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox3.Location = new System.Drawing.Point(484, 4);
            this.autoCompleteTextBox3.MaxDisplayedItems = 10;
            this.autoCompleteTextBox3.MinTypedCharacters = 3;
            this.autoCompleteTextBox3.Name = "autoCompleteTextBox3";
            this.autoCompleteTextBox3.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox3.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox3.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox3.SuggestionsFile = null;
            this.autoCompleteTextBox3.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(404, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Batch #:";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(304, 4);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(240, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Type:";
            // 
            // autoCompleteTextBox2
            // 
            this.autoCompleteTextBox2.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox2.AutoCompleteList")));
            this.autoCompleteTextBox2.CaseSensitive = false;
            this.autoCompleteTextBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox2.Location = new System.Drawing.Point(90, 4);
            this.autoCompleteTextBox2.MaxDisplayedItems = 10;
            this.autoCompleteTextBox2.MinTypedCharacters = 3;
            this.autoCompleteTextBox2.Name = "autoCompleteTextBox2";
            this.autoCompleteTextBox2.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox2.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox2.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox2.SuggestionsFile = null;
            this.autoCompleteTextBox2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Particle Mfg:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(807, 31);
            this.panel1.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.radioButton3);
            this.panel8.Controls.Add(this.radioButton8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(100, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(152, 23);
            this.panel8.TabIndex = 1;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.Location = new System.Drawing.Point(72, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton3.Size = new System.Drawing.Size(80, 23);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Black";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton8.Location = new System.Drawing.Point(0, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton8.Size = new System.Drawing.Size(72, 23);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Red";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Particle Color:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(807, 31);
            this.panel4.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.radioButton6);
            this.panel6.Controls.Add(this.radioButton7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(238, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 23);
            this.panel6.TabIndex = 2;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton6.Location = new System.Drawing.Point(87, 0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton6.Size = new System.Drawing.Size(120, 23);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "Fluorescent";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton7.Location = new System.Drawing.Point(0, 0);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton7.Size = new System.Drawing.Size(87, 23);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Visible";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.radioButton4);
            this.panel5.Controls.Add(this.radioButton5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(99, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 23);
            this.panel5.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton4.Location = new System.Drawing.Point(71, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton4.Size = new System.Drawing.Size(68, 23);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Dry";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton5.Location = new System.Drawing.Point(0, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton5.Size = new System.Drawing.Size(71, 23);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Wet";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Particle Type:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(807, 31);
            this.panel3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Location = new System.Drawing.Point(536, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(440, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thickness:";
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(360, 4);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 24);
            this.comboBox4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(216, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Surface Condition:";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(66, 4);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Material:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.autoCompleteTextBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(807, 31);
            this.panel2.TabIndex = 5;
            // 
            // autoCompleteTextBox1
            // 
            this.autoCompleteTextBox1.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox1.AutoCompleteList")));
            this.autoCompleteTextBox1.CaseSensitive = false;
            this.autoCompleteTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox1.Location = new System.Drawing.Point(322, 4);
            this.autoCompleteTextBox1.MaxDisplayedItems = 10;
            this.autoCompleteTextBox1.MinTypedCharacters = 3;
            this.autoCompleteTextBox1.Name = "autoCompleteTextBox1";
            this.autoCompleteTextBox1.Size = new System.Drawing.Size(200, 23);
            this.autoCompleteTextBox1.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox1.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox1.SuggestionsFile = null;
            this.autoCompleteTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(199, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Inspected:";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // MT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MT";
            this.Size = new System.Drawing.Size(809, 599);
            this.pnlMain.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel3;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox4;
        private Label label6;
        private ComboBox comboBox3;
        private Label label4;
        private AutoCompleteTextBox autoCompleteTextBox1;
        private Panel panel4;
        private Panel panel6;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Panel panel5;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Label label8;
        private Panel panel1;
        private Panel panel8;
        private RadioButton radioButton3;
        private RadioButton radioButton8;
        private Label label3;
        private Panel panel10;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label14;
        private Panel panel9;
        private AutoCompleteTextBox autoCompleteTextBox4;
        private Label label11;
        private ComboBox comboBox5;
        private Label label12;
        private AutoCompleteTextBox autoCompleteTextBox5;
        private Label label13;
        private Panel panel7;
        private AutoCompleteTextBox autoCompleteTextBox3;
        private Label label10;
        private ComboBox comboBox2;
        private Label label7;
        private AutoCompleteTextBox autoCompleteTextBox2;
        private Label label9;
        private Panel panel11;
        private DateTimePicker dateTimePicker1;
        private Label label15;
        private AutoCompleteTextBox autoCompleteTextBox7;
        private Label label17;
        private AutoCompleteTextBox autoCompleteTextBox8;
        private Label label16;
        private Label label18;
        private InspectionResults inspectionResults1;
    }
}
