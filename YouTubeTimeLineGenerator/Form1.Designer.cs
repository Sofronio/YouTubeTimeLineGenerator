namespace YouTubeTimeLineGenerator
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

