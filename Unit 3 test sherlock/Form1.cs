using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_3_test_sherlock
{
    /*
     * form
     * split container
     * 16 text boxes
     * 16 loose radio buttons
     * 2 group boxes
     * one holds 5 more radio buttons
     * the other holds a webbrowser
     * 16 pictureboxes
     * timer
     * status bar
     * error provider
     * tooltip
     * exit button
     * */
    public partial class Presidents : Form
    {
        //public bool allVals = true;
        public Presidents()
        {
            InitializeComponent();

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident /7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey( @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001,Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }
            //Set webbrowser group box to the name of the url accessed (the one for Benjamin Harrison)
            groupBox2.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            //Navigate webbrowser to the groupbox text(Benjamin Harrison url)
            this.webBrowser1.Navigate(groupBox2.Text);
            //send Benjamin Harrison picture box to the front
            this.HarrisonPictureBox.BringToFront();
            //start wtith benjamin harrison radio button selected
            //all filter button selected
            this.AllButton.Checked = true;
            //exit button not enabled
            exitButton.Enabled = false;
            {   //all event handlers for our picture boxes and radio buttons and text boxes
                this.HarrisonButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.FDRButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.ClintonButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.BuchananButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.PierceButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.BushButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.ObamaButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.KennedyButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.McKinleyButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.ReaganButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.EisenhowerButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.VanBurenButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.WashingtonButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.AdamsButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.RooseveltButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.JeffersonButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
                this.AllButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
                this.democratButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
                this.republicanButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
                this.democraticRepublicanButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
                this.federalistButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
                foreach(TextBox text in this.splitContainer1.Panel1.Controls.OfType<TextBox>())
                {
                    text.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                    text.Validating += new CancelEventHandler(TextBox__Validating);
                }
                /*
                this.HarrisonTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.HarrisonTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.ClintonTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.ClintonTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.BuchananTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.BuchananTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.PierceTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.PierceTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.BushTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.BushTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.ObamaTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.ObamaTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.KennedyTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.KennedyTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.McKinleyTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.McKinleyTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.ReaganTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.ReaganTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.VanBurenTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.VanBurenTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.WashingtonTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.WashingtonTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.AdamsTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.AdamsTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.RooseveltTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.RooseveltTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.JeffersonTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.JeffersonTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.EisenhowerTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.EisenhowerTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                this.FDRTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPressed);
                this.FDRTextBox.Validating += new CancelEventHandler(TextBox__Validating);
                */
                foreach(PictureBox pic in this.splitContainer1.Panel1.Controls.OfType<PictureBox>())
                {
                    pic.MouseHover += new EventHandler(PictureBox__MouseHover);
                    pic.MouseLeave += new EventHandler(PictureBox__MouseLeave);
                }

            }

            //webbrowser document complete event handler
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Webbrowser1__DocumentCompleted);
            //timer tick event handler
            this.timer1.Tick += new EventHandler(Timer1__Tick);
            //timer tag false
            this.timer1.Tag = false;
            //exitbutton clicked event (currently useless since exitbutton isn't enabled, but it will be eventually)
            exitButton.Click += new EventHandler(ExitButton__Click);

            

        }

        private void PresidentRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            //initialize string of name of president
            string name = rad.Text;
            //if this radio button is checked
            if(rad.Checked)
            {
                //go through all pictureboxes in the form
                foreach(Control cont in this.splitContainer1.Panel1.Controls.OfType<PictureBox>())
                {
                    //if the picture box has the same text as name (gonna be same as name of president)
                    PictureBox current = (PictureBox)cont;
                    if(current.Tag.Equals(name))
                    {
                        //reset picturebox width and height
                        //(in case of weirdness from mouehover and mouseleave events)
                        current.Height = 200;
                        current.Width = 130;
                        //send that picturebox to the front
                        current.BringToFront();
                    }
                }
                //create url string variable w basic wikipedia link
                string url = "https://en.m.wikipedia.org/wiki/";
                //replace spaces in president name with underscores
                string presName = rad.Text.Replace(' ', '_');
                //change url string to url+president name
                //change groupbox text to url
                this.groupBox2.Text = url + presName;
                //navigate to the url
                this.webBrowser1.Navigate(this.groupBox2.Text);

            }
        }
        private void FilterRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //if sender is checked
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                // foreach radio button
                foreach (Control button in this.splitContainer1.Panel1.Controls.OfType<RadioButton>())
                {
                    //make invisible
                    button.Visible = false;
                }
                //make all radio FILTER buttons visible again
                foreach (Control button in this.filterGroupBox.Controls)
                {
                    button.Visible = true;
                }
                //switch cases (sender text, which is gonna be the type of president they are
                switch (rad.Text)
                {
                    case "Democrat":
                        //separate lines for each democrat radio button visible
                        this.FDRButton.Visible = true;
                        this.ClintonButton.Visible = true;
                        this.BuchananButton.Visible = true;
                        this.PierceButton.Visible = true;
                        this.ObamaButton.Visible = true;
                        this.KennedyButton.Visible = true;
                        this.VanBurenButton.Visible = true;
                        //fdr radio button checked
                        this.FDRButton.Checked = true;
                        break;
                    case "Republican":
                        //separate lines for each republican radio button visible
                        this.HarrisonButton.Visible = true;
                        this.BushButton.Visible = true;
                        this.McKinleyButton.Visible = true;
                        this.ReaganButton.Visible = true;
                        this.EisenhowerButton.Visible = true;
                        this.RooseveltButton.Visible = true;
                        //harrison radio button is checked
                        this.HarrisonButton.Checked = true;
                        break;
                    case "Democratic-Republican":
                        //jefferson button is visible and checked
                        this.JeffersonButton.Visible = true;
                        this.JeffersonButton.Checked = true;
                        break;
                    case "Federalist":
                        //washington and adams buttons visible
                        this.WashingtonButton.Visible = true;
                        this.AdamsButton.Visible = true;
                        //washington button checked
                        this.WashingtonButton.Checked = true;
                        break;
                    case "All":
                        //foreach radiobutton in forms
                        foreach (Control radio in this.splitContainer1.Panel1.Controls.OfType<RadioButton>())
                        {
                            //make all radio buttons visible
                                radio.Visible = true;
                        }
                        //benjamin harrison button checked
                        this.HarrisonButton.Checked = true;
                        break;
                }
            }
        }
        private void TextBox__KeyPressed(object sender, KeyPressEventArgs e)
        {
            //if key pressed is backspace or digit
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
            {
                //.NET handles it
                e.Handled = false;
            }
            else
            {
                //else we handle it and do nothing with it
                e.Handled = true;
            }
        }

        private void TextBox__Validating(object sender, CancelEventArgs e)
        {

            TextBox box = (TextBox)sender;
            //if textbox has correct number in it
            if (box.Text == (string)box.Tag)
            {
                //dont set a (useful) error
                this.errorProvider1.SetError(box, null);
                //let user get out of the text box
                e.Cancel = false;
            }
            //if the textbox has 0
            else if (box.Text == "0")
            {
                //show an error saying it's the wrong number but still allow the user out of the text box
                this.errorProvider1.SetError(box, "That is the wrong number.");
                e.Cancel = false;
            }
            else
            {
                //tell user the number is wrong and don't let them out of the text box
                this.errorProvider1.SetError(box, "That is the wrong number.");
                e.Cancel = true;
            }
            //if timer isn't already started, start it
            if (timer1.Tag.Equals(false))
            {
                timer1.Start();
                timer1.Tag = true;
            }
        }
        
        private void Timer1__Tick(object sender, EventArgs e)
        {
            //boolean allvalues started as true
            bool allVals = true;
            //decrease progress bar value by proper amount
            --this.toolStripProgressBar1.Value;
            //foreach textbox
            foreach(Control textbox in this.splitContainer1.Panel1.Controls.OfType<TextBox>())
            {
                //if the text box's text isn't equal to its tag even once
                if (!textbox.Text.ToString().Equals(textbox.Tag.ToString()))
                {
                    //all values should be false
                    allVals = false;
                }
            }
            //if the value of progressbar is 0
            if (this.toolStripProgressBar1.Value == 0)
            {
                //foreach textbox
                foreach (Control textbox in this.splitContainer1.Panel1.Controls.OfType<TextBox>())
                {   
                    //set text to 0
                    textbox.Text = "0";
                }
                //stop timer
                timer1.Stop();
                //set bar value to full
                toolStripProgressBar1.Value = 120;
            }
            //if allvals boolean is true
            else if (allVals)
            {
                //stop timer
                timer1.Stop();
                //enable exit button
                this.exitButton.Enabled = true;
                //navigate to celebratory fireworks!
                webBrowser1.Navigate("https://www.youtube.com/watch?v=CWYKpwlVGso");
            }
        }
        private void PictureBox__MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            //if photo correct size (to prevent incorrect scaling)
            if (pic.Height == 200)
            {
                //enlarge it
                pic.Height = (int)((double)pic.Height * 1.5);
                pic.Width = (int)((double)pic.Width * 1.5);
            }


        }
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            //if photo is larger than normal (to prevent incorrect scaling)
            if (pic.Height > 200)
            {
                //shrink it
                pic.Height = (int)((double)pic.Height / 1.5);
                pic.Width = (int)((double)pic.Height / 1.5);
            }

        }
        private void ExitButton__Click(object sender, EventArgs e)
        {
            //close application
            Application.Exit();
        }

        private void Webbrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //grab a collection of all links with tagname a (this grabs all hyperlinks)
            HtmlElementCollection htmlElementCollection = webBrowser1.Document.GetElementsByTagName("A");
            //for each of those elements
            foreach(HtmlElement htmlElement in htmlElementCollection)
            {
                //set their title attribute to 'Professor Schuh for president!"
                htmlElement.SetAttribute("title", "Professor Schuh for president!");
            }
        }

        
    }
}
