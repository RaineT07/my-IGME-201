
namespace annoyingEssayWriter
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.breakButton = new System.Windows.Forms.Button();
            this.stretchedLabel = new System.Windows.Forms.Label();
            this.stretchedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time to stretch!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "I\'m done stretching!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1__Click);
            // 
            // breakButton
            // 
            this.breakButton.Location = new System.Drawing.Point(335, 192);
            this.breakButton.Name = "breakButton";
            this.breakButton.Size = new System.Drawing.Size(112, 42);
            this.breakButton.TabIndex = 2;
            this.breakButton.Text = "I need a break!";
            this.breakButton.UseVisualStyleBackColor = true;
            // 
            // stretchedLabel
            // 
            this.stretchedLabel.AutoSize = true;
            this.stretchedLabel.Location = new System.Drawing.Point(165, 115);
            this.stretchedLabel.Name = "stretchedLabel";
            this.stretchedLabel.Size = new System.Drawing.Size(182, 13);
            this.stretchedLabel.TabIndex = 3;
            this.stretchedLabel.Text = "Type \"I have stretched!\" into the box";
            this.stretchedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stretchedTextBox
            // 
            this.stretchedTextBox.Location = new System.Drawing.Point(208, 145);
            this.stretchedTextBox.Name = "stretchedTextBox";
            this.stretchedTextBox.Size = new System.Drawing.Size(100, 20);
            this.stretchedTextBox.TabIndex = 4;
            this.stretchedTextBox.Tag = "I have stretched!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 316);
            this.Controls.Add(this.stretchedTextBox);
            this.Controls.Add(this.stretchedLabel);
            this.Controls.Add(this.breakButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Time to stretch!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button breakButton;
        private System.Windows.Forms.Label stretchedLabel;
        private System.Windows.Forms.TextBox stretchedTextBox;
    }
}