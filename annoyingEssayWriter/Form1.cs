using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace annoyingEssayWriter
{
    public partial class helpfulEssayWriter : Form
    {
        private Thread thread1;
        public helpfulEssayWriter()
        {
            InitializeComponent();

            
            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);
            this.sansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);
            this.timesStretchedLabel.EnabledChanged -= new EventHandler(TimesStretchedLabel__EnabledChanged);
            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox__SelectionChanged);
            
            this.timer1.Tick += new EventHandler(Timer1__Tick);
            this.timer1.Start();

        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Value--;
            if(this.toolStripProgressBar1.Value==0)
            {
                Form2 stretchForm = new Form2(this);
                stretchForm.Show() ;
                this.timer1.Stop();
                this.toolStripProgressBar1.Value = 120;
            }
          
        }
        private void ChildFormFocus()
        {
            Random rand = new Random();
            int randIndex;
            int randChar;
            List<Char> vowelList = new List<Char> { 'a', 'e', 'i', 'o', 'u'};

            if(richTextBox.TextLength>0)
            {
                do
                {
                    randIndex = rand.Next(0, richTextBox.TextLength);
                    randChar = rand.Next(0, 5);
                    string text = richTextBox.Text;
                    text.Replace(text[randIndex], vowelList[randChar]);
                    richTextBox.Text = text;
                    Thread.Sleep(3000);

                }
                while (this.timer1.Enabled == false && this.richTextBox.Text.Contains('a') || this.richTextBox.Text.Contains('e') || this.richTextBox.Text.Contains('i') || this.richTextBox.Text.Contains('o') || this.richTextBox.Text.Contains('u'));
            }
            
        }



        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;
            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }
        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;
            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;
            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }
        private void MSSansSerifToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }
        private void TimesNewRomanToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }
        private void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripMenuItem.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripMenuItem.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripMenuItem.Checked = richTextBox.SelectionFont.Underline;
            }

        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripMenuItem toolStripMenuItem = null;

            if (e.ClickedItem == this.boldToolStripMenuItem)
            {
                fontStyle = FontStyle.Bold;
                toolStripMenuItem = this.boldToolStripMenuItem;
            }
            else if (e.ClickedItem == this.italicsToolStripMenuItem)
            {
                fontStyle = FontStyle.Italic;
                toolStripMenuItem = this.italicsToolStripMenuItem;
            }
            else if (e.ClickedItem == this.underlineToolStripMenuItem)
            {
                fontStyle = FontStyle.Underline;
                toolStripMenuItem = this.underlineToolStripMenuItem;
            }
            

            if (fontStyle != FontStyle.Regular)
            {
                toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

                SetSelectionFont(fontStyle, toolStripMenuItem.Checked);
            }

        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }
        private void TimesStretchedLabel__EnabledChanged(object sender, EventArgs e)
        {
            ToolStripStatusLabel status = (ToolStripStatusLabel)sender;
            string[] textPieces = status.Text.Split(':');
            Double counter = Double.Parse(textPieces[1]);
            counter = counter + 0.5;
            status.Text = $"{textPieces[0]}:{counter}";
        }

        private void This__Shown(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        

    }
}
