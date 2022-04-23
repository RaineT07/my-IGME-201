
namespace annoyingEssayWriter
{
    partial class Form4
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
            this.hoverBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.counterLabel = new System.Windows.Forms.Label();
            this.instructLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoverBox
            // 
            this.hoverBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hoverBox.Location = new System.Drawing.Point(169, 99);
            this.hoverBox.Name = "hoverBox";
            this.hoverBox.Size = new System.Drawing.Size(300, 200);
            this.hoverBox.TabIndex = 0;
            this.hoverBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.instructLabel);
            this.splitContainer1.Panel1.Controls.Add(this.counterLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hoverBox);
            this.splitContainer1.Size = new System.Drawing.Size(784, 461);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 1;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.counterLabel.Location = new System.Drawing.Point(330, 45);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(36, 25);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "10";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.Location = new System.Drawing.Point(140, 9);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(455, 29);
            this.instructLabel.TabIndex = 1;
            this.instructLabel.Text = "Break time! hover the mouse over the box";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.hoverBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hoverBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label instructLabel;
    }
}