
namespace Dyscord_PE_26
{
    partial class DyscordForm
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
            this.convGroupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.convRichTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.convGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // convGroupBox
            // 
            this.convGroupBox.Controls.Add(this.webBrowser1);
            this.convGroupBox.Controls.Add(this.convRichTextBox);
            this.convGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convGroupBox.Location = new System.Drawing.Point(0, 0);
            this.convGroupBox.Name = "convGroupBox";
            this.convGroupBox.Size = new System.Drawing.Size(800, 340);
            this.convGroupBox.TabIndex = 0;
            this.convGroupBox.TabStop = false;
            this.convGroupBox.Text = "conversation";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(607, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(190, 321);
            this.webBrowser1.TabIndex = 1;
            // 
            // convRichTextBox
            // 
            this.convRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.convRichTextBox.Name = "convRichTextBox";
            this.convRichTextBox.Size = new System.Drawing.Size(794, 321);
            this.convRichTextBox.TabIndex = 0;
            this.convRichTextBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msgRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.loginButton);
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.usersButton);
            this.splitContainer1.Panel2.Controls.Add(this.sendButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 106);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.TabIndex = 2;
            // 
            // msgRichTextBox
            // 
            this.msgRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.msgRichTextBox.Name = "msgRichTextBox";
            this.msgRichTextBox.Size = new System.Drawing.Size(530, 106);
            this.msgRichTextBox.TabIndex = 2;
            this.msgRichTextBox.Text = "";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(3, 20);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(145, 20);
            this.userTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(183, 18);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 68);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(84, 68);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 23);
            this.usersButton.TabIndex = 1;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(3, 68);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.convGroupBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 450);
            this.splitContainer2.SplitterDistance = 340;
            this.splitContainer2.TabIndex = 3;
            // 
            // DyscordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "DyscordForm";
            this.Text = "Dyscord";
            this.convGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox convGroupBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox convRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox msgRichTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}