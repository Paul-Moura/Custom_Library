using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomControls.Radiography
{
    partial class UT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UT));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.inspectionResults1 = new CustomControls.Radiography.InspectionResults();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMHz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label35 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.autoCompleteTextBox11 = new CustomControls.AutoCompleteTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox10 = new CustomControls.AutoCompleteTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox9 = new CustomControls.AutoCompleteTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox6 = new CustomControls.AutoCompleteTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox4 = new CustomControls.AutoCompleteTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox5 = new CustomControls.AutoCompleteTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox3 = new CustomControls.AutoCompleteTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox2 = new CustomControls.AutoCompleteTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox7 = new CustomControls.AutoCompleteTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox8 = new CustomControls.AutoCompleteTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.inspectionResults1);
            this.pnlMain.Controls.Add(this.panel9);
            this.pnlMain.Controls.Add(this.panel8);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.panel11);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(785, 717);
            this.pnlMain.TabIndex = 0;
            // 
            // inspectionResults1
            // 
            this.inspectionResults1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionResults1.ImagesDirectory = null;
            this.inspectionResults1.Location = new System.Drawing.Point(0, 418);
            this.inspectionResults1.Margin = new System.Windows.Forms.Padding(4);
            this.inspectionResults1.Name = "inspectionResults1";
            this.inspectionResults1.Size = new System.Drawing.Size(783, 297);
            this.inspectionResults1.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox3);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.comboBox8);
            this.panel9.Controls.Add(this.label25);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 387);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(4);
            this.panel9.Size = new System.Drawing.Size(783, 31);
            this.panel9.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox3.Location = new System.Drawing.Point(571, 4);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Left;
            this.label23.Location = new System.Drawing.Point(422, 4);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label23.Size = new System.Drawing.Size(149, 21);
            this.label23.TabIndex = 6;
            this.label23.Text = "Special Equipment:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(322, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Left;
            this.label24.Location = new System.Drawing.Point(222, 4);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label24.Size = new System.Drawing.Size(100, 21);
            this.label24.TabIndex = 2;
            this.label24.Text = "Batch / Lot:";
            // 
            // comboBox8
            // 
            this.comboBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(72, 4);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(150, 24);
            this.comboBox8.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Left;
            this.label25.Location = new System.Drawing.Point(4, 4);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label25.Size = new System.Drawing.Size(68, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "Couplant:";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Controls.Add(this.label35);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 240);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(783, 147);
            this.panel8.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chAngle,
            this.chMHz,
            this.chDiameter});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 124);
            this.dataGridView1.TabIndex = 8;
            // 
            // chAngle
            // 
            this.chAngle.HeaderText = "Angle";
            this.chAngle.Name = "chAngle";
            // 
            // chMHz
            // 
            this.chMHz.HeaderText = "MHz";
            this.chMHz.Name = "chMHz";
            // 
            // chDiameter
            // 
            this.chDiameter.HeaderText = "Diameter";
            this.chDiameter.Name = "chDiameter";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Top;
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label35.Size = new System.Drawing.Size(102, 21);
            this.label35.TabIndex = 7;
            this.label35.Text = "Transducer(s)";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(783, 147);
            this.panel5.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.autoCompleteTextBox11);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.autoCompleteTextBox10);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.comboBox6);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.autoCompleteTextBox9);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 114);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(4);
            this.panel7.Size = new System.Drawing.Size(781, 31);
            this.panel7.TabIndex = 11;
            // 
            // autoCompleteTextBox11
            // 
            this.autoCompleteTextBox11.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox11.AutoCompleteList")));
            this.autoCompleteTextBox11.CaseSensitive = false;
            this.autoCompleteTextBox11.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox11.Location = new System.Drawing.Point(720, 4);
            this.autoCompleteTextBox11.MaxDisplayedItems = 10;
            this.autoCompleteTextBox11.MinTypedCharacters = 3;
            this.autoCompleteTextBox11.Name = "autoCompleteTextBox11";
            this.autoCompleteTextBox11.Size = new System.Drawing.Size(40, 23);
            this.autoCompleteTextBox11.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox11.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox11.SuggestionsFile = null;
            this.autoCompleteTextBox11.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Left;
            this.label22.Location = new System.Drawing.Point(622, 4);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label22.Size = new System.Drawing.Size(98, 21);
            this.label22.TabIndex = 6;
            this.label22.Text = "Scan Gain:";
            // 
            // autoCompleteTextBox10
            // 
            this.autoCompleteTextBox10.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox10.AutoCompleteList")));
            this.autoCompleteTextBox10.CaseSensitive = false;
            this.autoCompleteTextBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox10.Location = new System.Drawing.Point(582, 4);
            this.autoCompleteTextBox10.MaxDisplayedItems = 10;
            this.autoCompleteTextBox10.MinTypedCharacters = 3;
            this.autoCompleteTextBox10.Name = "autoCompleteTextBox10";
            this.autoCompleteTextBox10.Size = new System.Drawing.Size(40, 23);
            this.autoCompleteTextBox10.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox10.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox10.SuggestionsFile = null;
            this.autoCompleteTextBox10.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Location = new System.Drawing.Point(438, 4);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label21.Size = new System.Drawing.Size(144, 21);
            this.label21.TabIndex = 4;
            this.label21.Text = "Primary Ref.Level:";
            // 
            // comboBox6
            // 
            this.comboBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(288, 4);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(150, 24);
            this.comboBox6.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(127, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label14.Size = new System.Drawing.Size(161, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "Reference Flaw Size:";
            // 
            // autoCompleteTextBox9
            // 
            this.autoCompleteTextBox9.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox9.AutoCompleteList")));
            this.autoCompleteTextBox9.CaseSensitive = false;
            this.autoCompleteTextBox9.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox9.Location = new System.Drawing.Point(87, 4);
            this.autoCompleteTextBox9.MaxDisplayedItems = 10;
            this.autoCompleteTextBox9.MinTypedCharacters = 3;
            this.autoCompleteTextBox9.Name = "autoCompleteTextBox9";
            this.autoCompleteTextBox9.Size = new System.Drawing.Size(40, 23);
            this.autoCompleteTextBox9.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox9.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox9.SuggestionsFile = null;
            this.autoCompleteTextBox9.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Location = new System.Drawing.Point(4, 4);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label19.Size = new System.Drawing.Size(83, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "DAC Points:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButton2);
            this.panel6.Controls.Add(this.radioButton1);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.autoCompleteTextBox6);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 83);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Size = new System.Drawing.Size(781, 31);
            this.panel6.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Location = new System.Drawing.Point(331, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton2.Size = new System.Drawing.Size(82, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Other";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Location = new System.Drawing.Point(169, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.radioButton1.Size = new System.Drawing.Size(162, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Direct Comparison";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(144, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label13.Size = new System.Drawing.Size(25, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "dB";
            // 
            // autoCompleteTextBox6
            // 
            this.autoCompleteTextBox6.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox6.AutoCompleteList")));
            this.autoCompleteTextBox6.CaseSensitive = false;
            this.autoCompleteTextBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox6.Location = new System.Drawing.Point(104, 4);
            this.autoCompleteTextBox6.MaxDisplayedItems = 10;
            this.autoCompleteTextBox6.MinTypedCharacters = 3;
            this.autoCompleteTextBox6.Name = "autoCompleteTextBox6";
            this.autoCompleteTextBox6.Size = new System.Drawing.Size(40, 23);
            this.autoCompleteTextBox6.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox6.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox6.SuggestionsFile = null;
            this.autoCompleteTextBox6.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Location = new System.Drawing.Point(4, 4);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label20.Size = new System.Drawing.Size(100, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Transfer Loss:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.autoCompleteTextBox4);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.autoCompleteTextBox5);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(781, 31);
            this.panel4.TabIndex = 9;
            // 
            // comboBox5
            // 
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(406, 4);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 24);
            this.comboBox5.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(324, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Material:";
            // 
            // autoCompleteTextBox4
            // 
            this.autoCompleteTextBox4.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox4.AutoCompleteList")));
            this.autoCompleteTextBox4.CaseSensitive = false;
            this.autoCompleteTextBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox4.Location = new System.Drawing.Point(174, 4);
            this.autoCompleteTextBox4.MaxDisplayedItems = 10;
            this.autoCompleteTextBox4.MinTypedCharacters = 3;
            this.autoCompleteTextBox4.Name = "autoCompleteTextBox4";
            this.autoCompleteTextBox4.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox4.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox4.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox4.SuggestionsFile = null;
            this.autoCompleteTextBox4.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(119, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "S/N:";
            // 
            // autoCompleteTextBox5
            // 
            this.autoCompleteTextBox5.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox5.AutoCompleteList")));
            this.autoCompleteTextBox5.CaseSensitive = false;
            this.autoCompleteTextBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox5.Location = new System.Drawing.Point(79, 4);
            this.autoCompleteTextBox5.MaxDisplayedItems = 10;
            this.autoCompleteTextBox5.MinTypedCharacters = 3;
            this.autoCompleteTextBox5.Name = "autoCompleteTextBox5";
            this.autoCompleteTextBox5.Size = new System.Drawing.Size(40, 23);
            this.autoCompleteTextBox5.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox5.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox5.SuggestionsFile = null;
            this.autoCompleteTextBox5.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sensitivity:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.autoCompleteTextBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.autoCompleteTextBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(781, 31);
            this.panel1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(397, 4);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(315, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Material:";
            // 
            // autoCompleteTextBox3
            // 
            this.autoCompleteTextBox3.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox3.AutoCompleteList")));
            this.autoCompleteTextBox3.CaseSensitive = false;
            this.autoCompleteTextBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox3.Location = new System.Drawing.Point(165, 4);
            this.autoCompleteTextBox3.MaxDisplayedItems = 10;
            this.autoCompleteTextBox3.MinTypedCharacters = 3;
            this.autoCompleteTextBox3.Name = "autoCompleteTextBox3";
            this.autoCompleteTextBox3.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox3.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox3.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox3.SuggestionsFile = null;
            this.autoCompleteTextBox3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(110, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "S/N:";
            // 
            // autoCompleteTextBox2
            // 
            this.autoCompleteTextBox2.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox2.AutoCompleteList")));
            this.autoCompleteTextBox2.CaseSensitive = false;
            this.autoCompleteTextBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox2.Location = new System.Drawing.Point(70, 4);
            this.autoCompleteTextBox2.MaxDisplayedItems = 10;
            this.autoCompleteTextBox2.MinTypedCharacters = 3;
            this.autoCompleteTextBox2.Name = "autoCompleteTextBox2";
            this.autoCompleteTextBox2.Size = new System.Drawing.Size(40, 23);
            this.autoCompleteTextBox2.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox2.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox2.SuggestionsFile = null;
            this.autoCompleteTextBox2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Linearity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calibration Block(s)";
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
            this.panel11.Location = new System.Drawing.Point(0, 62);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(4);
            this.panel11.Size = new System.Drawing.Size(783, 31);
            this.panel11.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(613, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Location = new System.Drawing.Point(527, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Cal. Due:";
            // 
            // autoCompleteTextBox7
            // 
            this.autoCompleteTextBox7.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("autoCompleteTextBox7.AutoCompleteList")));
            this.autoCompleteTextBox7.CaseSensitive = false;
            this.autoCompleteTextBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoCompleteTextBox7.Location = new System.Drawing.Point(377, 4);
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
            this.label17.Location = new System.Drawing.Point(307, 4);
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
            this.autoCompleteTextBox8.Location = new System.Drawing.Point(157, 4);
            this.autoCompleteTextBox8.MaxDisplayedItems = 10;
            this.autoCompleteTextBox8.MinTypedCharacters = 3;
            this.autoCompleteTextBox8.Name = "autoCompleteTextBox8";
            this.autoCompleteTextBox8.Size = new System.Drawing.Size(150, 23);
            this.autoCompleteTextBox8.SuggestionAlignment = CustomControls.SuggestionAlignment.Left;
            this.autoCompleteTextBox8.SuggestionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextBox8.SuggestionsFile = null;
            this.autoCompleteTextBox8.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Location = new System.Drawing.Point(102, 4);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 1;
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
            this.label18.Size = new System.Drawing.Size(98, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Flaw Detector:";
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
            this.panel3.Size = new System.Drawing.Size(783, 31);
            this.panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Location = new System.Drawing.Point(536, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 23);
            this.textBox2.TabIndex = 5;
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
            this.label5.TabIndex = 4;
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
            this.comboBox4.TabIndex = 3;
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
            this.label6.TabIndex = 2;
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
            this.comboBox3.TabIndex = 1;
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
            this.label4.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(783, 31);
            this.panel2.TabIndex = 0;
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
            // UT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UT";
            this.Size = new System.Drawing.Size(785, 717);
            this.pnlMain.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel panel3;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox4;
        private Label label6;
        private ComboBox comboBox3;
        private Label label4;
        private Panel panel2;
        private AutoCompleteTextBox autoCompleteTextBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel11;
        private DateTimePicker dateTimePicker1;
        private Label label15;
        private AutoCompleteTextBox autoCompleteTextBox7;
        private Label label17;
        private AutoCompleteTextBox autoCompleteTextBox8;
        private Label label16;
        private Label label18;
        private Panel panel5;
        private Panel panel4;
        private ComboBox comboBox5;
        private Label label10;
        private AutoCompleteTextBox autoCompleteTextBox4;
        private Label label11;
        private AutoCompleteTextBox autoCompleteTextBox5;
        private Label label12;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label8;
        private AutoCompleteTextBox autoCompleteTextBox3;
        private Label label7;
        private AutoCompleteTextBox autoCompleteTextBox2;
        private Label label9;
        private Label label3;
        private Panel panel6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label13;
        private AutoCompleteTextBox autoCompleteTextBox6;
        private Label label20;
        private Panel panel7;
        private AutoCompleteTextBox autoCompleteTextBox11;
        private Label label22;
        private AutoCompleteTextBox autoCompleteTextBox10;
        private Label label21;
        private ComboBox comboBox6;
        private Label label14;
        private AutoCompleteTextBox autoCompleteTextBox9;
        private Label label19;
        private Panel panel8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn chAngle;
        private DataGridViewTextBoxColumn chMHz;
        private DataGridViewTextBoxColumn chDiameter;
        private Label label35;
        private InspectionResults inspectionResults1;
        private Panel panel9;
        private TextBox textBox3;
        private Label label23;
        private TextBox textBox1;
        private Label label24;
        private ComboBox comboBox8;
        private Label label25;
    }
}
