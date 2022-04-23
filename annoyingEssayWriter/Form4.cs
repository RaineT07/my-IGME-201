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
    public partial class Form4 : Form
    {
        helpfulEssayWriter myParent;
        public Form4(helpfulEssayWriter bigParent)
        {
            myParent = bigParent;
            InitializeComponent();
            this.hoverBox.MouseHover += new EventHandler(HoverBox__MouseOver);
//this.hoverBox.MouseLeave += new EventHandler(HoverBox__MouseLeave);
            myParent.timesStretchedLabel.EnabledChanged += new EventHandler(TimesStretchedLabel__EnabledChanged);
            Random rand = new Random();
            int newX = rand.Next(1, 485);
            int newY = rand.Next(1, 187);
            this.counterLabel.Text = "10";
            this.hoverBox.Left = newX;
            this.hoverBox.Top = newY;

        }

        private void TimesStretchedLabel__EnabledChanged(object sender, EventArgs e)
        {
            ToolStripStatusLabel status = (ToolStripStatusLabel)sender;
            string[] textPieces = status.Text.Split(':');
            Double counter = Double.Parse(textPieces[1]);
            counter = counter + 0.25;
            status.Text = $"{textPieces[0]}:{counter}";
        }

        private void HoverBox__MouseOver(object sender, EventArgs e)
        {

            for(int i=10; i>0;i--)
            {
                this.counterLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }

            myParent.timesStretchedLabel.Enabled = false;
            myParent.timesStretchedLabel.Enabled = true;
            this.Close();

        }
        //private void HoverBox__MouseLeave(object sender, EventArgs e)
        //{
        //    Random rand = new Random();
        //    int newX = rand.Next(1, 485);
        //    int newY = rand.Next(1, 187);
        //    this.counterLabel.Text = "10";
        //    this.hoverBox.Left = newX;
        //    this.hoverBox.Top = newY;
        //}
    }
}
