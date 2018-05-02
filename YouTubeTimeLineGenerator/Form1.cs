<<<<<<< HEAD
﻿using System;
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
using System.Runtime.InteropServices;
using System.Xml;
using System.Diagnostics;

namespace YouTubeTimeLineGenerator
{        
    public partial class Form1 : Form
    {
        List<subtitle> mySubtitle = new List<subtitle>();
        string[] filesPath;
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

            public string WordStart
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

            public string WordEnd
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

            public bool Selected
            {
                get
                {
                    return selected;
                }

                set
                {
                    selected = value;
                }
            }

            private string content;
            private string timeStart;
            private string timeEnd;
            private int position;
            private bool selected;
        }
        
        public Form1()
        {
            InitializeComponent();
            this.textBox_vtt.AllowDrop = true;
            this.textBox_vtt.DragOver += new DragEventHandler(textBox_vtt_DragOver);
            this.textBox_vtt.DragDrop += new DragEventHandler(textBox_vtt_DragDrop);            
        }

        //private void OldOrNew()
        //{
        //    if(radioButton_new.Checked == true)
        //    {
        //        string stringNew = "";
        //        for (int i = 11; i < textBox_vtt.Lines.Count()+11; i = i + 8)
        //        {
        //            stringNew += textBox_vtt.Lines[i] + "\r\n" + textBox_vtt.Lines[i + 3] + "\r\n";
        //        }
        //        textBox_vttResult.Text = stringNew;
        //    }
        //}

        private void button_processVTT_Click(object sender, EventArgs e)
        {
            button_loadToSeperate.Enabled = true;
            textBox_vttResult.Clear();
            mySubtitle.Clear();
            if (radioButton_VTT.Checked == true)
                processVTT();
            else
                processXML();
        }

        private string msToTime(string ms)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(Convert.ToInt64(ms));
            string result = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds,
                                    t.Milliseconds);
            return result;
        }

        private void processXML()
        {
            if (filesPath[0] != "")
            {
                string strXML = "";
                int Position = 0;
                for (int i = 0; i < textBox_vtt.Lines.Count(); i++)
                {
                    strXML += textBox_vtt.Lines[i] + "\r\n";
                }

                textBox_vttResult.Text = strXML;
                mySubtitle.Clear();
                XmlDocument myXMLDoc = new XmlDocument();
                myXMLDoc.Load(filesPath[0]);

                var ps = myXMLDoc.GetElementsByTagName("p");
                //each p is a TimedLine
                //p with content, contains p.LineStart, p.LineEnd is p.Next.LineStart.
                //p without content, contains only p.LineStart, providing p.Pre.LineEnd.
                //p with content could be the last line.
                //p without content could not be the last line. 2018-05-02
                int psFlag = 0;
                foreach (XmlNode p in ps)
                {
                    string Content;
                    string WordStart;
                    string WordEnd;
                    
                    if (p.ChildNodes.Count != 0)
                    {
                        //Debug.WriteLine(p.InnerXml);
                        if (p.InnerXml.Contains("<"))
                        {
                            if (p.Attributes["t"] != null)
                            {
                                //each s is a content, which may contain "t" as s.WordStart
                                //the first s in p doesn't contain "t", so ss[0].WordStart is LineStart
                                //other s contains "t", as WordStart
                                //s could be the last in p, s.WordEnd is p.LineEnd, which is p.Next.LineStart
                                var ss = p.ChildNodes;
                                int ssFlag = 0;
                                foreach (XmlNode s in ss)
                                {
                                    Content = s.InnerText.Trim();
                                    if (s.Attributes["t"] == null)
                                    {
                                        //s is the first word, WordStart should be LineStart.
                                        //s maybe the only word.
                                        //s maybe the final word.
                                        WordStart = p.Attributes["t"].Value;
                                        if (s.NextSibling == null)
                                        {
                                            if (ssFlag == ss.Count -1)
                                            {
                                                //s is the final word, which means there is no more lines, WordEnd should be LineStart + Duration, which is a bit longer than normal ones.
                                                WordEnd = (Convert.ToInt32(p.Attributes["t"].Value) + Convert.ToInt32(p.Attributes["d"].Value)).ToString();
                                            }
                                            else
                                            {
                                                //s is the only word, but not the final word, WordEnd should be next LineStart.
                                                WordEnd = ps[psFlag + 1].Attributes["t"].Value;
                                            }
                                        }
                                        else
                                        {
                                            //s is not the only word, WordEnd should be LineStart + next WordStart.
                                            WordEnd = (Convert.ToInt32(p.Attributes["t"].Value) + Convert.ToInt32(ss[ssFlag + 1].Attributes["t"].Value)).ToString();
                                        }
                                    }
                                    else
                                    {
                                        //s is not the first word, WordStart should be LineStart + TimeShift.
                                        //s cannot be the only word.
                                        //s maybe the final word.
                                        WordStart = (Convert.ToInt32(p.Attributes["t"].Value) + Convert.ToInt32(s.Attributes["t"].Value)).ToString();
                                        if (s.NextSibling == null)
                                        {
                                            //s is the last word.
                                            //s maybe the final word.
                                            if (ssFlag == ss.Count -1)
                                            {
                                                //s is the final word, which means there is no more lines, WordEnd should be LineStart + Duration, which is a bit longer than normal ones.
                                                WordEnd = (Convert.ToInt32(p.Attributes["t"].Value) + Convert.ToInt32(p.Attributes["d"].Value)).ToString();
                                            }
                                            else
                                            {
                                                //s is the last word, but not the final word, WordEnd should be next LineStart.
                                                WordEnd = ps[psFlag + 1].Attributes["t"].Value;
                                            }
                                        }
                                        else
                                        {
                                            //s is not the last word, WordEnd should be LineStart + next WordStart.
                                            WordEnd = (Convert.ToInt32(p.Attributes["t"].Value) + Convert.ToInt32(ss[ssFlag + 1].Attributes["t"].Value)).ToString();
                                        }
                                    }
                                    ssFlag++;
                                    Debug.WriteLine(Content + "\t" + WordStart + "\t" + WordEnd);
                                    mySubtitle.Add(new subtitle { Content = Content, WordStart = msToTime(WordStart), WordEnd = msToTime(WordEnd), Position = Position, Selected = false });
                                    Position += Content.Length + 1;
                                }
                                Debug.WriteLine("");
                            }
                        }
                    }
                    else
                    {
                        if (p.Attributes["t"] != null)
                        {
                            //s could maybe [Music] or [Applause]
                        }
                    }
                    psFlag++;
                }
            }
        }

        private void processVTT()
        {
            
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
            //(?<Content>(\w+')?(\w+))                  get Content
            //(<\/?c.*?>)*                              drop            </c></c.colorFFFFFF>
            //<(?<WordEnd>\d{2}:\d{2}:\d{2}.\d{3})?     get WordEnd     have 0 or one time "00:21:54.539", if it's the end, there would be no time;
            string patternContent = @"(?<Content>(\w+')?(\w+))(<\/?c.*?>)*<(?<WordEnd>\d{2}:\d{2}:\d{2}.\d{3})?";

            string LineStart = "";
            string LineEnd = "";
            string Content = "";
            string WordStart = "";
            string WordEnd = "";
            int Position = 0;

            for (int i = 10; i < textBox_vtt.Lines.Count(); i = i + 8)
            {
                Content += textBox_vtt.Lines[i] + "\r\n" + textBox_vtt.Lines[i + 2] + "\r\n";
            }

            textBox_vttResult.Text = Content;
            foreach (var text in textBox_vttResult.Lines)
            {
                //match TimeLine                
                if (Regex.IsMatch(text, patternTime))
                {
                    LineStart = Regex.Match(text, patternTime).Groups["TimeStart"].Value;
                    LineEnd = Regex.Match(text, patternTime).Groups["TimeEnd"].Value;
                    WordStart = LineStart;
                }
                else
                {
                    if (Regex.IsMatch(text, patternContent))
                    {
                        foreach (Match m in Regex.Matches(text, patternContent))
                        {
                            if (m.Groups["WordEnd"].Value == "")
                            {
                                WordEnd = LineEnd;
                            }
                            else
                            {
                                WordEnd = m.Groups["WordEnd"].Value;
                            }
                            mySubtitle.Add(new subtitle { Content = m.Groups["Content"].Value, WordStart = WordStart, WordEnd = WordEnd, Position = Position, Selected = false });
                            Position = Position + m.Groups["Content"].Value.Length + 1;
                            WordStart = WordEnd;
                        }
                    }
                }
            }
        }

        private void generateRichText()
        {            
            //Random rnd = new Random();          
            foreach (var ms in mySubtitle)
            {
                //Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                richTextBox_Words.Select(richTextBox_Words.TextLength, 0);
                richTextBox_Words.SelectionFont = new Font(richTextBox_Words.SelectedText, 12);
                //richTextBox2.SelectionColor = randomColor;
                richTextBox_Words.AppendText(ms.Content + " ");
            }
        }

        private void increaseFontSize(int size)
        {
            int selectTemp = richTextBox_Words.SelectionStart;
            richTextBox_Words.Select(0, richTextBox_Words.TextLength);
            richTextBox_Words.SelectionFont = new Font(richTextBox_Words.SelectedText, richTextBox_Words.SelectionFont.Size + size);

            richTextBox_Words.SelectionStart = selectTemp;
        }

        private void decreaseFontSize(int size)
        {
            int selectTemp = richTextBox_Words.SelectionStart;
            richTextBox_Words.Select(0, richTextBox_Words.TextLength);
            richTextBox_Words.SelectionFont = new Font(richTextBox_Words.SelectedText, richTextBox_Words.SelectionFont.Size - size);

            richTextBox_Words.SelectionStart = selectTemp;
        }


        private void generateASS(List<subtitle> input)
        {
            richTextBox_ass.Clear();
            List<int> selectedItemIndexes = new List<int>();
            string assTimeStart = input[0].WordStart;
            string assTimeEnd = "";
            string assContent = "";            
            foreach (var m in input)
            {
                //if( m.TimeStart.Length < 5)
                //    m.TimeStart =  "00:00:00.000";
                assContent += m.Content + " ";
                if (m.Selected)
                {
                    assTimeEnd = m.WordEnd;
                    string assLine = ("Dialogue: 0," + assTimeStart + "," + assTimeEnd + ",Default,,0,0,0,," + assContent).Trim() + "\n";
                    richTextBox_ass.AppendText(assLine);
                    assContent = "";
                    assTimeStart = m.WordEnd;
                }
            }            
        }

        private void button_convertToAss_Click(object sender, EventArgs e)
        {
            generateASS(mySubtitle);
        }
        

        private void textBox_vtt_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                filesPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(filesPath[0]))
                {
                    String[] allLines = File.ReadAllLines(filesPath[0]);
                    string temp = "";
                    foreach (string allLine in allLines)
                        temp += allLine + "\r\n";
                    textBox_vtt.Text = temp;
                }
            }
        }

        private void textBox_vtt_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button_loadToSeperate_Click(object sender, EventArgs e)
        {
            richTextBox_Words.Clear();
            for(int i=0;i<mySubtitle.Count;i++)
            {
                mySubtitle[i].Selected = false;
            }        
            richTextBox_Words.Enabled = true;
            if (radioButton_VTT.Checked == true)
            {
                generateRichText();
            }
            else
                generateRichText();
        }

        private void richTextBox_Words_MouseUp(object sender, MouseEventArgs e)
        {            
            RichTextBox box = (RichTextBox)sender;
            
            int ClickIndex = box.GetCharIndexFromPosition(new Point(e.X, e.Y));
            
            int lastSpacePosition = box.Find(" ", 0, ClickIndex, RichTextBoxFinds.Reverse);

            int WordIndex = mySubtitle.FindIndex(x => x.Position == lastSpacePosition+1);
            //if ((WordIndex < 0) || (WordIndex > mySubtitle.Count - 1))
            //    WordIndex = mySubtitle.Count - 1;            
            if (mySubtitle[WordIndex].Selected)
            {
                mySubtitle[WordIndex].Selected = false;
                richTextBox_Words.SelectionStart = mySubtitle[WordIndex].Position + mySubtitle[WordIndex].Content.Length;
                richTextBox_Words.SelectionLength = 1;
                richTextBox_Words.SelectionBackColor = richTextBox_Words.BackColor;
                richTextBox_Words.SelectionLength = 0;
            }
            else
            {
                mySubtitle[WordIndex].Selected = true;
                richTextBox_Words.SelectionStart = mySubtitle[WordIndex].Position + mySubtitle[WordIndex].Content.Length;
                richTextBox_Words.SelectionLength = 1;
                richTextBox_Words.SelectionBackColor = Color.Red;
                richTextBox_Words.SelectionLength = 0;
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

                int selectTemp = richTextBox_Words.SelectionStart;

                richTextBox_Words.Select(0, richTextBox_Words.TextLength);
                richTextBox_Words.SelectionColor = c;
                //richTextBox2.BackColor = c2;
                richTextBox_Words.SelectionStart = selectTemp;
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
}
=======
﻿using System;
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
>>>>>>> origin/master
