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
    public partial class Form2 : Form
    {
        helpfulEssayWriter myParent;
        public Form2(helpfulEssayWriter parentForm)
        {
           
            InitializeComponent();
            myParent = parentForm;
            this.button1.Click += new EventHandler(Button1__Click);
            this.breakButton.Click += new EventHandler(BreakButton__Click);
            parentForm.timesStretchedLabel.EnabledChanged += new EventHandler(TimesStretchedLabel__EnabledChanged);
            this.stretchedTextBox.TextChanged += new EventHandler(StretchedTextBox__TextChanged);

            stretchedLabel.Visible = true;
            stretchedTextBox.Visible = true;
            button1.Enabled = false;
            breakButton.Enabled = false;
        }
        private void StretchedTextBox__TextChanged(object sender, EventArgs e)
        {
            if(stretchedTextBox.Text.Equals(stretchedTextBox.Tag))
            {
                button1.Enabled = true;
                breakButton.Enabled = true;
            }
        }
            
        private void Button1__Click(object sender, EventArgs e)
        {
            myParent.timesStretchedLabel.Enabled = false;
            myParent.timesStretchedLabel.Enabled = true;
            Form3 botherForm = new Form3(myParent);
            botherForm.Show();
            this.Close();
            
        }

        private void BreakButton__Click(object sender, EventArgs e)
        {
            Form4 breakform = new Form4(myParent);
            breakform.Show();
            this.Close();
        }

        private void TimesStretchedLabel__EnabledChanged(object sender, EventArgs e)
        {
            ToolStripStatusLabel status = (ToolStripStatusLabel)sender;
            string[] textPieces = status.Text.Split(':');
            Double counter = Double.Parse(textPieces[1]);
            counter = counter + 0.25;
            status.Text = $"{textPieces[0]}:{counter}";
        }
    }
}
