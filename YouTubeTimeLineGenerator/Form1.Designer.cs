<<<<<<< HEAD
﻿namespace YouTubeTimeLineGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_processVTT = new System.Windows.Forms.Button();
            this.textBox_vtt = new System.Windows.Forms.TextBox();
            this.richTextBox_ass = new System.Windows.Forms.RichTextBox();
            this.button_convertToAss = new System.Windows.Forms.Button();
            this.textBox_vttResult = new System.Windows.Forms.TextBox();
            this.radioButton_VTT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_XML = new System.Windows.Forms.RadioButton();
            this.richTextBox_Words = new System.Windows.Forms.RichTextBox();
            this.button_loadToSeperate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_color = new System.Windows.Forms.Button();
            this.button_decrease = new System.Windows.Forms.Button();
            this.button_increase = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_processVTT
            // 
            this.button_processVTT.Location = new System.Drawing.Point(797, 23);
            this.button_processVTT.Name = "button_processVTT";
            this.button_processVTT.Size = new System.Drawing.Size(200, 121);
            this.button_processVTT.TabIndex = 0;
            this.button_processVTT.Text = "Process VTT";
            this.button_processVTT.UseVisualStyleBackColor = true;
            this.button_processVTT.Click += new System.EventHandler(this.button_processVTT_Click);
            // 
            // textBox_vtt
            // 
            this.textBox_vtt.Location = new System.Drawing.Point(38, 23);
            this.textBox_vtt.Multiline = true;
            this.textBox_vtt.Name = "textBox_vtt";
            this.textBox_vtt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_vtt.Size = new System.Drawing.Size(500, 210);
            this.textBox_vtt.TabIndex = 3;
            this.textBox_vtt.Text = "Drag and Drop your YouTube VTT file here.";
            this.textBox_vtt.WordWrap = false;
            this.textBox_vtt.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_vtt_DragDrop);
            this.textBox_vtt.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_vtt_DragOver);
            // 
            // richTextBox_ass
            // 
            this.richTextBox_ass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_ass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_ass.Location = new System.Drawing.Point(571, 259);
            this.richTextBox_ass.Name = "richTextBox_ass";
            this.richTextBox_ass.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_ass.Size = new System.Drawing.Size(1068, 226);
            this.richTextBox_ass.TabIndex = 0;
            this.richTextBox_ass.Text = resources.GetString("richTextBox_ass.Text");
            this.richTextBox_ass.WordWrap = false;
            // 
            // button_convertToAss
            // 
            this.button_convertToAss.Location = new System.Drawing.Point(1437, 23);
            this.button_convertToAss.Name = "button_convertToAss";
            this.button_convertToAss.Size = new System.Drawing.Size(200, 121);
            this.button_convertToAss.TabIndex = 6;
            this.button_convertToAss.Text = "Convert to ASS";
            this.button_convertToAss.UseVisualStyleBackColor = true;
            this.button_convertToAss.Click += new System.EventHandler(this.button_convertToAss_Click);
            // 
            // textBox_vttResult
            // 
            this.textBox_vttResult.Location = new System.Drawing.Point(38, 259);
            this.textBox_vttResult.Multiline = true;
            this.textBox_vttResult.Name = "textBox_vttResult";
            this.textBox_vttResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_vttResult.Size = new System.Drawing.Size(500, 226);
            this.textBox_vttResult.TabIndex = 7;
            this.textBox_vttResult.WordWrap = false;
            // 
            // radioButton_VTT
            // 
            this.radioButton_VTT.AutoSize = true;
            this.radioButton_VTT.Checked = true;
            this.radioButton_VTT.Location = new System.Drawing.Point(27, 35);
            this.radioButton_VTT.Name = "radioButton_VTT";
            this.radioButton_VTT.Size = new System.Drawing.Size(123, 25);
            this.radioButton_VTT.TabIndex = 9;
            this.radioButton_VTT.TabStop = true;
            this.radioButton_VTT.Text = "Auto VTT";
            this.radioButton_VTT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_XML);
            this.groupBox1.Controls.Add(this.radioButton_VTT);
            this.groupBox1.Location = new System.Drawing.Point(571, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Type";
            // 
            // radioButton_XML
            // 
            this.radioButton_XML.AutoSize = true;
            this.radioButton_XML.Location = new System.Drawing.Point(27, 75);
            this.radioButton_XML.Name = "radioButton_XML";
            this.radioButton_XML.Size = new System.Drawing.Size(123, 25);
            this.radioButton_XML.TabIndex = 10;
            this.radioButton_XML.Text = "Auto XML";
            this.radioButton_XML.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Words
            // 
            this.richTextBox_Words.AutoWordSelection = true;
            this.richTextBox_Words.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Words.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Words.Enabled = false;
            this.richTextBox_Words.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Words.Name = "richTextBox_Words";
            this.richTextBox_Words.ReadOnly = true;
            this.richTextBox_Words.Size = new System.Drawing.Size(1597, 571);
            this.richTextBox_Words.TabIndex = 11;
            this.richTextBox_Words.Text = "";
            this.richTextBox_Words.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_Words_MouseUp);
            // 
            // button_loadToSeperate
            // 
            this.button_loadToSeperate.Enabled = false;
            this.button_loadToSeperate.Location = new System.Drawing.Point(1015, 23);
            this.button_loadToSeperate.Name = "button_loadToSeperate";
            this.button_loadToSeperate.Size = new System.Drawing.Size(200, 121);
            this.button_loadToSeperate.TabIndex = 12;
            this.button_loadToSeperate.Text = "Load Words";
            this.button_loadToSeperate.UseVisualStyleBackColor = true;
            this.button_loadToSeperate.Click += new System.EventHandler(this.button_loadToSeperate_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(200, 506);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(82, 61);
            this.button_color.TabIndex = 13;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Visible = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_decrease
            // 
            this.button_decrease.Location = new System.Drawing.Point(38, 506);
            this.button_decrease.Name = "button_decrease";
            this.button_decrease.Size = new System.Drawing.Size(75, 61);
            this.button_decrease.TabIndex = 15;
            this.button_decrease.Text = "-";
            this.button_decrease.UseVisualStyleBackColor = true;
            this.button_decrease.Click += new System.EventHandler(this.button_decrease_Click);
            // 
            // button_increase
            // 
            this.button_increase.Location = new System.Drawing.Point(119, 506);
            this.button_increase.Name = "button_increase";
            this.button_increase.Size = new System.Drawing.Size(75, 61);
            this.button_increase.TabIndex = 16;
            this.button_increase.Text = "+";
            this.button_increase.UseVisualStyleBackColor = true;
            this.button_increase.Click += new System.EventHandler(this.button_increase_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1188);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1674, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox_Words);
            this.panel1.Location = new System.Drawing.Point(38, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 575);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1210);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_increase);
            this.Controls.Add(this.button_decrease);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.button_loadToSeperate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox_ass);
            this.Controls.Add(this.textBox_vttResult);
            this.Controls.Add(this.button_convertToAss);
            this.Controls.Add(this.textBox_vtt);
            this.Controls.Add(this.button_processVTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YouTubeTimeLineGenerator v0.0.3 by Sofronio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_processVTT;
        private System.Windows.Forms.TextBox textBox_vtt;
        //private FlickerFreeListBox listBox1;
        private System.Windows.Forms.Button button_convertToAss;
        private System.Windows.Forms.TextBox textBox_vttResult;
        private System.Windows.Forms.RichTextBox richTextBox_ass;
        //private FlickerFreeListBox listBox2;
        private System.Windows.Forms.RadioButton radioButton_VTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_XML;
        private System.Windows.Forms.RichTextBox richTextBox_Words;
        //private ExRichTextBox richTextBox2;
        private System.Windows.Forms.Button button_loadToSeperate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_increase;
        private System.Windows.Forms.Button button_decrease;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

=======
﻿namespace YouTubeTimeLineGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_new = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_old = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_color = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button_decrease = new System.Windows.Forms.Button();
            this.button_increase = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new YouTubeTimeLineGenerator.FlickerFreeListBox();
            this.listBox1 = new YouTubeTimeLineGenerator.FlickerFreeListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 121);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process VTT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(500, 210);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Drag and Drop your YouTube VTT file here.";
            this.textBox1.WordWrap = false;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox1_DragOver);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(571, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(1068, 226);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1437, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 121);
            this.button2.TabIndex = 6;
            this.button2.Text = "Convert to ASS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 259);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(500, 226);
            this.textBox2.TabIndex = 7;
            this.textBox2.WordWrap = false;
            // 
            // radioButton_new
            // 
            this.radioButton_new.AutoSize = true;
            this.radioButton_new.Checked = true;
            this.radioButton_new.Location = new System.Drawing.Point(27, 35);
            this.radioButton_new.Name = "radioButton_new";
            this.radioButton_new.Size = new System.Drawing.Size(68, 25);
            this.radioButton_new.TabIndex = 9;
            this.radioButton_new.TabStop = true;
            this.radioButton_new.Text = "New";
            this.radioButton_new.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_old);
            this.groupBox1.Controls.Add(this.radioButton_new);
            this.groupBox1.Location = new System.Drawing.Point(587, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VTT Version";
            // 
            // radioButton_old
            // 
            this.radioButton_old.AutoSize = true;
            this.radioButton_old.Location = new System.Drawing.Point(27, 75);
            this.radioButton_old.Name = "radioButton_old";
            this.radioButton_old.Size = new System.Drawing.Size(68, 25);
            this.radioButton_old.TabIndex = 10;
            this.radioButton_old.Text = "Old";
            this.radioButton_old.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.AutoWordSelection = true;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(1597, 571);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            this.richTextBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox2_MouseUp);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1050, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 121);
            this.button3.TabIndex = 12;
            this.button3.Text = "Load Words";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(200, 506);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(82, 61);
            this.button_color.TabIndex = 13;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Visible = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(1214, 172);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 46);
            this.listBox3.TabIndex = 14;
            this.listBox3.Visible = false;
            // 
            // button_decrease
            // 
            this.button_decrease.Location = new System.Drawing.Point(38, 506);
            this.button_decrease.Name = "button_decrease";
            this.button_decrease.Size = new System.Drawing.Size(75, 61);
            this.button_decrease.TabIndex = 15;
            this.button_decrease.Text = "-";
            this.button_decrease.UseVisualStyleBackColor = true;
            this.button_decrease.Click += new System.EventHandler(this.button_decrease_Click);
            // 
            // button_increase
            // 
            this.button_increase.Location = new System.Drawing.Point(119, 506);
            this.button_increase.Name = "button_increase";
            this.button_increase.Size = new System.Drawing.Size(75, 61);
            this.button_increase.TabIndex = 16;
            this.button_increase.Text = "+";
            this.button_increase.UseVisualStyleBackColor = true;
            this.button_increase.Click += new System.EventHandler(this.button_increase_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1188);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1674, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Location = new System.Drawing.Point(38, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 575);
            this.panel1.TabIndex = 18;
            // 
            // listBox2
            // 
            this.listBox2.ColumnWidth = 48;
            this.listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(814, 172);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(129, 46);
            this.listBox2.TabIndex = 8;
            this.listBox2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 48;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(1050, 172);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 46);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1210);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_increase);
            this.Controls.Add(this.button_decrease);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YouTubeTimeLineGenerator v0.0.2 by Sofronio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.ListBox listBox1;
        private FlickerFreeListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FlickerFreeListBox listBox2;
        private System.Windows.Forms.RadioButton radioButton_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_old;
        private System.Windows.Forms.RichTextBox richTextBox2;
        //private ExRichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button_increase;
        private System.Windows.Forms.Button button_decrease;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

>>>>>>> origin/master
