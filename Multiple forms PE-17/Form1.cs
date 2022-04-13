using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_forms_PE_17
{
    public partial class parentForm : Form
    {
        public parentForm()
        {
            InitializeComponent();
            this.minTextBox.Text = "1";
            this.maxTextBox.Text = "100";
            this.startButton.Click += new EventHandler(startButton_Click);
            this.minTextBox.KeyPress += new KeyPressEventHandler(MinTextBox__KeyPress);
            this.maxTextBox.KeyPress += new KeyPressEventHandler(MaxTextBox__KeyPress);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            lowNumber = Int32.Parse(minTextBox.Text);
            highNumber = Int32.Parse(maxTextBox.Text);


            // if not a valid range
            if ( lowNumber>=highNumber )
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid. the high number cannot be the same or lower than the low number.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }
        private void MinTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void MaxTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
