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
    public partial class GameForm : Form
    {
        int guesses=0;
        int lowValue;
        int highValue;
        int nRandom;
        public GameForm(int lowValue, int highValue)
        {
            InitializeComponent();
            this.lowValue = lowValue;
            this.highValue = highValue;
            Random rand = new Random();
            nRandom = rand.Next(lowValue+1, highValue);
            this.timer1.Interval = 500;
            this.timer1.Tick += new EventHandler(Timer1__Tick);
            this.currentGuessTextBox.KeyPress += new KeyPressEventHandler(CurrentGuessTextBox__KeyPress);
            this.button1.Click += new EventHandler(Button1__Click);
            this.label1.Visible = false;
            this.timer1.Start();
        }
        private void Timer1__Tick(object sender, EventArgs e)
        {
            --toolStripProgressBar1.Value;

            if(toolStripProgressBar1.Value == 0)
            {
                timer1.Stop();
                MessageBox.Show($"Time is up! you had {this.guesses} guesses!");
                this.Close();
            }
        }

        private void CurrentGuessTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
            {
                e.Handled = true;
            }
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            this.guesses++;
            int currentGuess = Int32.Parse(this.currentGuessTextBox.Text);
            

            if(currentGuess == this.nRandom)
            {
                MessageBox.Show($"Woohoo, you got it in {guesses} guesses!");
                this.Close();
            }
            else if(currentGuess > this.nRandom)
            {
                this.label1.Text = $"Your guess of {currentGuess} is too HIGH";
                label1.Visible = true;
                this.currentGuessTextBox.Clear();
            }
            else if(currentGuess < this.nRandom)
            {
                this.label1.Text = $"Your guess of {currentGuess} is too LOW";
                label1.Visible = true;
                this.currentGuessTextBox.Clear();
            }
        }
    }

}
