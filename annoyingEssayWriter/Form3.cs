using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace annoyingEssayWriter
{
    public partial class Form3 : Form
    {
        int randInt;
        helpfulEssayWriter myParent;
        public Form3(helpfulEssayWriter bigParent)
        {
            InitializeComponent();

            myParent = bigParent;
            foreach(RadioButton rad in this.Controls.OfType<RadioButton>())
            {
                rad.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            }
            this.button1.Click += new EventHandler(Button1__Clicked);
            Random rand = new Random();
            randInt = rand.Next(1, 18);
        }

        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                int checkedNum = Int32.Parse(rad.Tag.ToString());
                if (checkedNum.Equals(this.randInt))
                {
                    this.button1.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = false;
                }
            }
        }
        private void Button1__Clicked(object sender, EventArgs e)
        {
            //myParent.timer1.Start();
            this.Close();
        }
    }
}
