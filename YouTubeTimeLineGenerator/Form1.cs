using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace YouTubeTimeLineGenerator
{
        
    public partial class Form1 : Form
    {
        List<subtitle> mySubtitle = new List<subtitle>();
        class subtitle
        {
            public string Content
            {
                get
                {
                    return content;
                }

                set
                {
                    content = value;
                }
            }

            public string TimeStart
            {
                get
                {
                    return timeStart;
                }

                set
                {
                    timeStart = value;
                }
            }

            public string TimeEnd
            {
                get
                {
                    return timeEnd;
                }

                set
                {
                    timeEnd = value;
                }
            }

            public int Position
            {
                get
                {
                    return position;
                }

                set
                {
                    position = value;
                }
            }

            private string content;
            private string timeStart;
            private string timeEnd;
            private int position;
        }

        public Form1()
        {
            InitializeComponent();
            this.textBox1.AllowDrop = true;
            this.textBox1.DragOver += new DragEventHandler(textBox1_DragOver);
            this.textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);
        }

        private void OldOrNew()
        {
            if(radioButton_new.Checked == true)
            {
                string stringNew = "";
                for (int i = 11; i < textBox1.Lines.Count()+11; i = i + 8)
                {
                    stringNew += textBox1.Lines[i] + "\r\n" + textBox1.Lines[i + 3] + "\r\n";
                }
                textBox2.Text = stringNew;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            mySubtitle.Clear();

            string TimeStart = "";
            string TimeEnd = "";
            int WordPosition = 0;

            //when it's a timed line
            //00:00:24.510 --> 00:00:27.170 align:start position:0%
            //(\d{2}:\d{2}:\d{2}.\d{3})                 $1              00:00:24.510
            //\s-->\s                                   wasted          " --> "
            //(\d{2}:\d{2}:\d{2}.\d{3})                 $2              00:00:27.170
            //" position:0%"                            wasted
            string patternTime = @"(?<TimeStart>\d{2}:\d{2}:\d{2}.\d{3})\s-->\s(?<TimeEnd>\d{2}:\d{2}:\d{2}.\d{3})";

            //when it's a content line
            //another<00:21:54.539><c> one</c><00:21:54.809><c> on</c><00:21:54.960><c> top</c><00:21:55.639><c> by</c><00:21:56.639><c> the</c></c><c.colorCCCCCC><00:21:56.700><c> way</c></c><c.colorE5E5E5><00:21:56.940><c> double</c><00:21:57.840><c> it</c></c>
            //<c.colorE5E5E5>close<00:20:24.640><c> it</c></c><c.colorCCCCCC><00:20:24.910><c> close</c><00:20:25.060><c> it</c></c><c.colorE5E5E5><00:20:25.180><c> close</c><00:20:25.570><c> it</c><00:20:25.690><c> and</c><00:20:26.110><c> so</c><00:20:26.740><c> and</c></c><c.colorCCCCCC><00:20:27.010><c> so</c></c>
            //(\w+')?(\w+)  we're that's it's           $1+$2           we're
            //(</c>)??                                  wasted $3
            //(<c.colorCCCCCC>)??                       wasted $4
            //<                                         wasted
            //(<\d{2}:\d{2}:\d{2}.\d{3}>)               $5              00:20:24.910
            //>                                         wasted
            string patternLine = @"(?<Content>(\w+')?(\w+))(</c>){0,2}(<c\.color[0-9a-fA-F]{1,6}>)??<(?<TimeEnd>\d{2}:\d{2}:\d{2}.\d{3})>";

            //match the ending
            //it </ c ></ c >
            //\s                                        wasted
            //(\w+')?(\w+)                              $1             it
            //(</c>){1,2}$                              wasted
            //\d{2}:\d{2}:\d{2}.\d{3}                   ?<Duration>
            string patternLineEnding = @"\s(?<Content>(\w+')?(\w+))(</c>){1,2}$";

            //match those lines with only one word
            //^                                         wasted
            //(\w+')?(\w+)                              $1+$2
            //(</c>){1,2}$                              wasted
            string patternLineOneWord = @"^(<c\.color[0-9a-fA-F]{1,6}>)??(?<Content>(\w+')?(\w+))(</c>){1,2}$";

            //match applause and music
            //[Applause] [Music]
            string[] textLines;

            if (radioButton_new.Checked == true)
            {
                string stringNew = "";
                for (int i = 10; i < textBox1.Lines.Count(); i = i + 8)
                {
                    stringNew += textBox1.Lines[i] + "\r\n" + textBox1.Lines[i + 2] + "\r\n";
                }
                textBox2.Text = stringNew;
                textLines = textBox2.Lines;
            }
            else
                textLines = textBox1.Lines;

            foreach (var text in textLines)
            {
                //match TimeLine                
                MatchCollection matches = Regex.Matches(text, patternTime);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    //listBox1.Items.Add(groups["TimeStart"].Value + "\t" + groups["TimeEnd"].Value);
                    TimeStart = groups["TimeStart"].Value;
                    TimeEnd = groups["TimeEnd"].Value;
                }

                string TimeWordStart = TimeStart;

                //match one-word-only lines
                matches = Regex.Matches(text, patternLineOneWord);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    listBox1.Items.Add(groups["Content"].Value);
                    listBox2.Items.Add(groups["Content"].Value + "\t" + TimeStart + "\t" + TimeEnd + "\t" + WordPosition.ToString());
                    listBox3.Items.Add(WordPosition.ToString());         
                    mySubtitle.Add(new subtitle { Content = groups["Content"].Value, TimeStart = TimeStart, TimeEnd = TimeEnd, Position = WordPosition });

                    //mySubtitleItem.Content = groups["Content"].Value;
                    //mySubtitleItem.TimeStart = TimeStart;
                    //mySubtitleItem.TimeEnd = TimeEnd;
                    //mySubtitleItem.Position = WordPosition;
                    //mySubtitle.Add(mySubtitleItem);

                    WordPosition = WordPosition + groups["Content"].Value.Length + 1;
                }


                //match normal lines
                matches = Regex.Matches(text, patternLine);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    listBox1.Items.Add(groups["Content"].Value);
                    listBox2.Items.Add(groups["Content"].Value + "\t" + TimeWordStart + "\t" + groups["TimeEnd"].Value + "\t" + WordPosition.ToString());
                    listBox3.Items.Add(WordPosition.ToString());
                    mySubtitle.Add(new subtitle { Content = groups["Content"].Value, TimeStart = TimeWordStart, TimeEnd = groups["TimeEnd"].Value, Position = WordPosition });

                    TimeWordStart = groups["TimeEnd"].Value;
                    WordPosition = WordPosition + groups["Content"].Value.Length + 1;
                }

                //match line ending
                matches = Regex.Matches(text, patternLineEnding);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    listBox1.Items.Add(groups["Content"].Value);
                    listBox2.Items.Add(groups["Content"].Value + "\t" + TimeWordStart + "\t" + TimeEnd + "\t" + WordPosition.ToString());
                    listBox3.Items.Add(WordPosition.ToString());
                    mySubtitle.Add(new subtitle { Content = groups["Content"].Value, TimeStart = TimeWordStart, TimeEnd = groups["TimeEnd"].Value, Position = WordPosition });
                    WordPosition = WordPosition + groups["Content"].Value.Length + 1;
                }
            }


            
        }

        //private void generateLabels(ListBox listBox)
        //{
        //    List<Label> customLabels = new List<Label>();
        //    int labelCounter = 0;
        //    foreach (string content in listBox.Items)
        //    {
        //        labelCounter++;
        //        Label label = new Label();
        //        string regex = @"(?<Content>(\w+')?(\w+))\t(?<TimeStart>\d{2}:\d{2}:\d{2}.\d{3})\t(?<TimeEnd>\d{2}:\d{2}:\d{2}.\d{3})";
        //        Match match = Regex.Match(content, regex);
        //        GroupCollection groups = match.Groups;


        //        //label.Location = new System.Drawing.Point(317, 119 + customLabels.Count * 26);
        //        label.Parent = flowLayoutPanel1;
        //        label.Name = "labelContent" + labelCounter.ToString();
        //        label.Text = groups["Content"].Value;
        //        label.AutoSize = true;
        //        customLabels.Add(label);
        //        flowLayoutPanel1.Controls.Add(label);

        //        if (labelCounter > Convert.ToUInt32(textBox2.Text))
        //            break;
        //    }
        //    flowLayoutPanel1.Controls.Add(customLabels[customLabels.Count - 1] as Control);            
        //}


        //private void generateButtons(ListBox listBox)
        //{
        //    //this.SuspendLayout();
        //    List<Button> customButtons = new List<Button>();
        //    int buttonCounter = 0;
        //    foreach (string content in listBox.Items)
        //    {
        //        buttonCounter++;
        //        Button button  = new Button();
        //        //button.SuspendLayout();
        //        string regex = @"(?<Content>(\w+')?(\w+))\t(?<TimeStart>\d{2}:\d{2}:\d{2}.\d{3})\t(?<TimeEnd>\d{2}:\d{2}:\d{2}.\d{3})";
        //        Match match = Regex.Match(content, regex);
        //        GroupCollection groups = match.Groups;


        //        //label.Location = new System.Drawing.Point(317, 119 + customLabels.Count * 26);
        //        button.Parent = flowLayoutPanel1;
        //        button.Name = "labelContent" + buttonCounter.ToString();
        //        button.Text = groups["Content"].Value;
        //        button.AutoSize = true;
        //        customButtons.Add(button);
        //        //flowLayoutPanel1.Controls.Add(button);
        //        button.ResumeLayout();
        //        if (buttonCounter > Convert.ToUInt32(textBox2.Text))
        //            break;
        //    }
        //    flowLayoutPanel1.Controls.Add(customButtons[customButtons.Count - 1] as Control);
        //    //this.ResumeLayout();
        //}

        private void generateRichText(ListBox listBox)
        {
            //int labelCounter = 0;
            richTextBox2.Clear();
            Random rnd = new Random();
            foreach (string content in listBox.Items)
            {

                string regex = @"(?<Content>(\w+')?(\w+))\t(?<TimeStart>\d{2}:\d{2}:\d{2}.\d{3})\t(?<TimeEnd>\d{2}:\d{2}:\d{2}.\d{3})";
                Match match = Regex.Match(content, regex);
                GroupCollection groups = match.Groups;

                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                richTextBox2.Select(richTextBox2.TextLength, 0);
                richTextBox2.SelectionFont = new Font(richTextBox2.SelectedText, 12);
                //richTextBox2.SelectionColor = randomColor;
                richTextBox2.AppendText(groups["Content"].Value + " ");

                //if ((labelCounter > Convert.ToUInt32(textBox2.Text)) && Convert.ToUInt32(textBox2.Text) != 0)
                //    break;
                //labelCounter++;
            }
        }

        private void increaseFontSize(int size)
        {
            int selectTemp = richTextBox2.SelectionStart;
            richTextBox2.Select(0, richTextBox2.TextLength);
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectedText, richTextBox2.SelectionFont.Size + size);

            richTextBox2.SelectionStart = selectTemp;

        }

        private void decreaseFontSize(int size)
        {
            int selectTemp = richTextBox2.SelectionStart;
            richTextBox2.Select(0, richTextBox2.TextLength);
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectedText, richTextBox2.SelectionFont.Size - size);

            richTextBox2.SelectionStart = selectTemp;

        }


        private void generateASS(ListBox listBox)
        {
            richTextBox1.Clear();
            List<int> selectedItemIndexes = new List<int>();
            foreach (int o in listBox1.SelectedIndices)
            {
                selectedItemIndexes.Add(o);
            }
            int lastMatchedPosition = 0;
            selectedItemIndexes.Sort();
            foreach (int i in selectedItemIndexes)
            {
                string regex = @"(?<Content>(\w+')?(\w+))\t\d(?<TimeStart>\d:\d{2}:\d{2}.\d{2})\d\t\d(?<TimeEnd>\d:\d{2}:\d{2}.\d{2})\d\t(?<Position>.*)";
                string content = "";
                string assTimeStart = "";
                string assTimeEnd = "";
                string assContent = "";
                for (int j = lastMatchedPosition; j <= i; j++)
                {
                    content = listBox2.Items[j].ToString();
                    Match match = Regex.Match(content, regex);
                    GroupCollection groupsStart = match.Groups;
                    assContent += groupsStart["Content"].Value + " ";
                    if (assTimeStart == "")
                        assTimeStart = groupsStart["TimeStart"].Value;
                    assTimeEnd = groupsStart["TimeEnd"].Value;
                    lastMatchedPosition++;
                }
                string assLine = "Dialogue: 0," + assTimeStart + "," + assTimeEnd + ",Default,,0,0,0,," + assContent + "\n";
                richTextBox1.AppendText(assLine);
                lastMatchedPosition = i + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //generateLabels(listBox1);
            //generateRichText(listBox1);
            generateASS(listBox1);
            //generateButtons(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> selectedItemIndexes = new List<int>();
            foreach (int o in listBox1.SelectedIndices)
            {
                selectedItemIndexes.Add(o);                
            }
            //this.Text = "";
            listBox2.ClearSelected();
            listBox3.ClearSelected();


            foreach (int i in selectedItemIndexes)
            {
                //this.Text = this.Text + " " + i.ToString();                
                listBox2.SetSelected(i, true);
                listBox3.SetSelected(i, true);
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                //if (System.IO.Directory.Exists(files[0]))
                if (System.IO.File.Exists(files[0]))
                {
                    String[] allLines = System.IO.File.ReadAllLines(files[0]);
                    string temp = "";
                    foreach (string allLine in allLines)
                        temp += allLine + "\r\n";
                    textBox1.Text = temp;
                }
            }
        }

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Enabled = true;
            if (radioButton_new.Checked == true)
            {
                generateRichText(listBox2);
            }
            else
                generateRichText(listBox1);
        }

        private void richTextBox2_MouseUp(object sender, MouseEventArgs e)
        {
            bool isLastWord = false;
            RichTextBox box = (RichTextBox)sender;
            Point mouseLocation = new Point(e.X, e.Y);
            box.SelectionStart = box.GetCharIndexFromPosition(mouseLocation);
            box.SelectionLength = 0;
            int selectionStart = box.SelectionStart;
            int lineFromCharIndex = box.GetLineFromCharIndex(selectionStart);
            int charIndexFromLine = box.GetFirstCharIndexFromLine(lineFromCharIndex);

            int currentLine = box.GetLineFromCharIndex(selectionStart) + 1;
            int currentCol = box.SelectionStart - charIndexFromLine + 1;

            int charIndexFromMouse = box.GetCharIndexFromPosition(new Point(e.X, e.Y));
            int nextSpacePosition = box.Find(" ", charIndexFromMouse, RichTextBoxFinds.NoHighlight);
            int contentIndexFromMouse = mySubtitle.FindIndex(x => x.Position == nextSpacePosition + 1);
            if (contentIndexFromMouse == -1)
                contentIndexFromMouse = mySubtitle.Count;

            this.Text = contentIndexFromMouse.ToString();

            //click YYth word, and from YYst word position to （YY+1)th word position, change backcolor to blue, forecolor to white
            //            
            int selectedIndex = contentIndexFromMouse - 1;
            if (listBox1.SelectedIndices.Contains(selectedIndex))
            {                
                listBox1.SelectedIndices.Remove(selectedIndex);
                richTextBox2.SelectionStart = richTextBox2.Find(" ", charIndexFromMouse, RichTextBoxFinds.NoHighlight);
                richTextBox2.SelectionLength = 1;
                richTextBox2.SelectionBackColor = richTextBox2.BackColor;
                //richTextBox2.SelectionColor = Color.Black;
            }
            else
            {
                listBox1.SelectedIndices.Add(selectedIndex);                
                richTextBox2.SelectionStart = richTextBox2.Find(" ", charIndexFromMouse, RichTextBoxFinds.NoHighlight);
                richTextBox2.SelectionLength = 1;
                richTextBox2.SelectionBackColor = Color.Red;
                //richTextBox2.SelectionColor = Color.Red;
            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDialog1.Color;
                button_color.BackColor = c;
                Color c2 = Color.FromArgb(c.R > 127 ? 0 : 255, c.G > 127 ? 0 : 255, c.B > 127 ? 0 : 255);
                button_color.ForeColor = c2;

                int selectTemp = richTextBox2.SelectionStart;

                richTextBox2.Select(0, richTextBox2.TextLength);
                richTextBox2.SelectionColor = c;
                //richTextBox2.BackColor = c2;

                richTextBox2.SelectionStart = selectTemp;
            }
        }

        private void button_decrease_Click(object sender, EventArgs e)
        {
            decreaseFontSize(1);
        }

        private void button_increase_Click(object sender, EventArgs e)
        {
            increaseFontSize(1);
        }
    }


    internal class ExRichTextBox : RichTextBox
    {
        public ExRichTextBox()
        {
            Selectable = true;
        }
        const int WM_SETFOCUS = 0x0007;
        const int WM_KILLFOCUS = 0x0008;
        [DefaultValue(true)]
        public bool Selectable { get; set; }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SETFOCUS && !Selectable)
                m.Msg = WM_KILLFOCUS;

            base.WndProc(ref m);
        }
    }


    internal class FlickerFreeListBox : System.Windows.Forms.ListBox
    {
        public FlickerFreeListBox()
        {
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                true);
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.Items.Count > 0)
            {
                e.DrawBackground();
                //e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(this.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
                e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(this.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
            }
            base.OnDrawItem(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Region iRegion = new Region(e.ClipRectangle);
            e.Graphics.FillRegion(new SolidBrush(this.BackColor), iRegion);
            if (this.Items.Count > 0)
            {
                for (int i = 0; i < this.Items.Count; ++i)
                {
                    System.Drawing.Rectangle irect = this.GetItemRectangle(i);
                    if (e.ClipRectangle.IntersectsWith(irect))
                    {
                        if ((this.SelectionMode == SelectionMode.One && this.SelectedIndex == i)
                        || (this.SelectionMode == SelectionMode.MultiSimple && this.SelectedIndices.Contains(i))
                        || (this.SelectionMode == SelectionMode.MultiExtended && this.SelectedIndices.Contains(i)))
                        {
                            OnDrawItem(new DrawItemEventArgs(e.Graphics, this.Font,
                                irect, i,
                                DrawItemState.Selected, this.ForeColor,
                                this.BackColor));
                        }
                        else
                        {
                            OnDrawItem(new DrawItemEventArgs(e.Graphics, this.Font,
                                irect, i,
                                DrawItemState.Default, this.ForeColor,
                                this.BackColor));
                        }
                        iRegion.Complement(irect);
                    }
                }
            }
            base.OnPaint(e);
        }
    }
}
