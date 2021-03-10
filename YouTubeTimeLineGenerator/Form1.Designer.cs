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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_XML = new System.Windows.Forms.RadioButton();
            this.richTextBox_Words = new System.Windows.Forms.RichTextBox();
            this.button_loadToSeperate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_color = new System.Windows.Forms.Button();
            this.button_decrease = new System.Windows.Forms.Button();
            this.button_increase = new System.Windows.Forms.Button();
            this.tableLayoutPanel_all = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_button = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_output = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_outputbutton = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_all.SuspendLayout();
            this.tableLayoutPanel_button.SuspendLayout();
            this.tableLayoutPanel_output.SuspendLayout();
            this.tableLayoutPanel_outputbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_processVTT
            // 
            this.button_processVTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_processVTT.Location = new System.Drawing.Point(126, 0);
            this.button_processVTT.Margin = new System.Windows.Forms.Padding(8, 0, 8, 9);
            this.button_processVTT.Name = "button_processVTT";
            this.button_processVTT.Size = new System.Drawing.Size(102, 58);
            this.button_processVTT.TabIndex = 30;
            this.button_processVTT.Text = "Process VTT";
            this.button_processVTT.UseVisualStyleBackColor = true;
            this.button_processVTT.Click += new System.EventHandler(this.button_processVTT_Click);
            // 
            // textBox_vtt
            // 
            this.textBox_vtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_vtt.Location = new System.Drawing.Point(16, 16);
            this.textBox_vtt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_vtt.Multiline = true;
            this.textBox_vtt.Name = "textBox_vtt";
            this.textBox_vtt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_vtt.Size = new System.Drawing.Size(252, 205);
            this.textBox_vtt.TabIndex = 100;
            this.textBox_vtt.Text = "Drag and Drop your YouTube VTT file here.";
            this.textBox_vtt.WordWrap = false;
            this.textBox_vtt.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_vtt_DragDrop);
            this.textBox_vtt.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_vtt_DragOver);
            // 
            // richTextBox_ass
            // 
            this.richTextBox_ass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_ass.Location = new System.Drawing.Point(9, 80);
            this.richTextBox_ass.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
            this.richTextBox_ass.Name = "richTextBox_ass";
            this.richTextBox_ass.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_ass.Size = new System.Drawing.Size(587, 125);
            this.richTextBox_ass.TabIndex = 80;
            this.richTextBox_ass.Text = resources.GetString("richTextBox_ass.Text");
            // 
            // button_convertToAss
            // 
            this.button_convertToAss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_convertToAss.Location = new System.Drawing.Point(480, 0);
            this.button_convertToAss.Margin = new System.Windows.Forms.Padding(8, 0, 0, 9);
            this.button_convertToAss.Name = "button_convertToAss";
            this.button_convertToAss.Size = new System.Drawing.Size(112, 58);
            this.button_convertToAss.TabIndex = 50;
            this.button_convertToAss.Text = "Convert to ASS";
            this.button_convertToAss.UseVisualStyleBackColor = true;
            this.button_convertToAss.Click += new System.EventHandler(this.button_convertToAss_Click);
            // 
            // textBox_vttResult
            // 
            this.textBox_vttResult.Location = new System.Drawing.Point(356, 2);
            this.textBox_vttResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_vttResult.Multiline = true;
            this.textBox_vttResult.Name = "textBox_vttResult";
            this.textBox_vttResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_vttResult.Size = new System.Drawing.Size(61, 18);
            this.textBox_vttResult.TabIndex = 7;
            this.textBox_vttResult.Visible = false;
            this.textBox_vttResult.WordWrap = false;
            // 
            // radioButton_VTT
            // 
            this.radioButton_VTT.AutoSize = true;
            this.radioButton_VTT.Checked = true;
            this.radioButton_VTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_VTT.Location = new System.Drawing.Point(2, 2);
            this.radioButton_VTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_VTT.Name = "radioButton_VTT";
            this.radioButton_VTT.Size = new System.Drawing.Size(98, 18);
            this.radioButton_VTT.TabIndex = 10;
            this.radioButton_VTT.TabStop = true;
            this.radioButton_VTT.Text = "Auto VTT";
            this.radioButton_VTT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(102, 58);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton_VTT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_XML, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(102, 44);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // radioButton_XML
            // 
            this.radioButton_XML.AutoSize = true;
            this.radioButton_XML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_XML.Location = new System.Drawing.Point(2, 24);
            this.radioButton_XML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_XML.Name = "radioButton_XML";
            this.radioButton_XML.Size = new System.Drawing.Size(98, 18);
            this.radioButton_XML.TabIndex = 20;
            this.radioButton_XML.Text = "Auto XML";
            this.radioButton_XML.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Words
            // 
            this.richTextBox_Words.AutoWordSelection = true;
            this.tableLayoutPanel_all.SetColumnSpan(this.richTextBox_Words, 2);
            this.richTextBox_Words.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Words.Enabled = false;
            this.richTextBox_Words.Location = new System.Drawing.Point(16, 286);
            this.richTextBox_Words.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_Words.Name = "richTextBox_Words";
            this.richTextBox_Words.ReadOnly = true;
            this.richTextBox_Words.Size = new System.Drawing.Size(852, 259);
            this.richTextBox_Words.TabIndex = 11;
            this.richTextBox_Words.Text = "";
            this.richTextBox_Words.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_Words_MouseUp);
            // 
            // button_loadToSeperate
            // 
            this.button_loadToSeperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_loadToSeperate.Enabled = false;
            this.button_loadToSeperate.Location = new System.Drawing.Point(244, 0);
            this.button_loadToSeperate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 9);
            this.button_loadToSeperate.Name = "button_loadToSeperate";
            this.button_loadToSeperate.Size = new System.Drawing.Size(102, 58);
            this.button_loadToSeperate.TabIndex = 40;
            this.button_loadToSeperate.Text = "Load Words";
            this.button_loadToSeperate.UseVisualStyleBackColor = true;
            this.button_loadToSeperate.Click += new System.EventHandler(this.button_loadToSeperate_Click);
            // 
            // button_color
            // 
            this.button_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_color.Location = new System.Drawing.Point(106, 9);
            this.button_color.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.button_color.Name = "button_color";
            this.button_color.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.button_color.Size = new System.Drawing.Size(138, 40);
            this.button_color.TabIndex = 13;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Visible = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_decrease
            // 
            this.button_decrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_decrease.Location = new System.Drawing.Point(49, 9);
            this.button_decrease.Margin = new System.Windows.Forms.Padding(0, 9, 1, 9);
            this.button_decrease.Name = "button_decrease";
            this.button_decrease.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.button_decrease.Size = new System.Drawing.Size(48, 40);
            this.button_decrease.TabIndex = 70;
            this.button_decrease.TabStop = false;
            this.button_decrease.Text = "-";
            this.button_decrease.UseVisualStyleBackColor = true;
            this.button_decrease.Click += new System.EventHandler(this.button_decrease_Click);
            // 
            // button_increase
            // 
            this.button_increase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_increase.Location = new System.Drawing.Point(0, 9);
            this.button_increase.Margin = new System.Windows.Forms.Padding(0, 9, 1, 9);
            this.button_increase.Name = "button_increase";
            this.button_increase.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.button_increase.Size = new System.Drawing.Size(48, 40);
            this.button_increase.TabIndex = 60;
            this.button_increase.TabStop = false;
            this.button_increase.Text = "+";
            this.button_increase.UseVisualStyleBackColor = true;
            this.button_increase.Click += new System.EventHandler(this.button_increase_Click);
            // 
            // tableLayoutPanel_all
            // 
            this.tableLayoutPanel_all.AutoSize = true;
            this.tableLayoutPanel_all.ColumnCount = 2;
            this.tableLayoutPanel_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_all.Controls.Add(this.richTextBox_Words, 0, 2);
            this.tableLayoutPanel_all.Controls.Add(this.tableLayoutPanel_button, 0, 1);
            this.tableLayoutPanel_all.Controls.Add(this.textBox_vtt, 0, 0);
            this.tableLayoutPanel_all.Controls.Add(this.tableLayoutPanel_output, 1, 0);
            this.tableLayoutPanel_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_all.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_all.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.tableLayoutPanel_all.Name = "tableLayoutPanel_all";
            this.tableLayoutPanel_all.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.tableLayoutPanel_all.RowCount = 3;
            this.tableLayoutPanel_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel_all.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel_all.Size = new System.Drawing.Size(884, 561);
            this.tableLayoutPanel_all.TabIndex = 19;
            // 
            // tableLayoutPanel_button
            // 
            this.tableLayoutPanel_button.ColumnCount = 3;
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_button.Controls.Add(this.button_increase, 0, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_color, 2, 0);
            this.tableLayoutPanel_button.Controls.Add(this.button_decrease, 1, 0);
            this.tableLayoutPanel_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_button.Location = new System.Drawing.Point(16, 225);
            this.tableLayoutPanel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_button.Name = "tableLayoutPanel_button";
            this.tableLayoutPanel_button.RowCount = 1;
            this.tableLayoutPanel_button.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_button.Size = new System.Drawing.Size(252, 57);
            this.tableLayoutPanel_button.TabIndex = 0;
            // 
            // tableLayoutPanel_output
            // 
            this.tableLayoutPanel_output.AutoSize = true;
            this.tableLayoutPanel_output.ColumnCount = 1;
            this.tableLayoutPanel_output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_output.Controls.Add(this.richTextBox_ass, 0, 1);
            this.tableLayoutPanel_output.Controls.Add(this.tableLayoutPanel_outputbutton, 0, 0);
            this.tableLayoutPanel_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_output.Location = new System.Drawing.Point(272, 16);
            this.tableLayoutPanel_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_output.Name = "tableLayoutPanel_output";
            this.tableLayoutPanel_output.RowCount = 2;
            this.tableLayoutPanel_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel_output.Size = new System.Drawing.Size(596, 205);
            this.tableLayoutPanel_output.TabIndex = 12;
            // 
            // tableLayoutPanel_outputbutton
            // 
            this.tableLayoutPanel_outputbutton.ColumnCount = 5;
            this.tableLayoutPanel_outputbutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_outputbutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_outputbutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_outputbutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_outputbutton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_outputbutton.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel_outputbutton.Controls.Add(this.button_processVTT, 1, 0);
            this.tableLayoutPanel_outputbutton.Controls.Add(this.button_convertToAss, 4, 0);
            this.tableLayoutPanel_outputbutton.Controls.Add(this.textBox_vttResult, 3, 0);
            this.tableLayoutPanel_outputbutton.Controls.Add(this.button_loadToSeperate, 2, 0);
            this.tableLayoutPanel_outputbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_outputbutton.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_outputbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_outputbutton.Name = "tableLayoutPanel_outputbutton";
            this.tableLayoutPanel_outputbutton.RowCount = 1;
            this.tableLayoutPanel_outputbutton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_outputbutton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_outputbutton.Size = new System.Drawing.Size(592, 67);
            this.tableLayoutPanel_outputbutton.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel_all);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "YouTubeTimeLineGenerator v0.0.3.5 by Sofronio";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_all.ResumeLayout(false);
            this.tableLayoutPanel_all.PerformLayout();
            this.tableLayoutPanel_button.ResumeLayout(false);
            this.tableLayoutPanel_output.ResumeLayout(false);
            this.tableLayoutPanel_outputbutton.ResumeLayout(false);
            this.tableLayoutPanel_outputbutton.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_all;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_outputbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

