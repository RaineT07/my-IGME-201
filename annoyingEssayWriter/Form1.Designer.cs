
namespace annoyingEssayWriter
{
    partial class helpfulEssayWriter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpfulEssayWriter));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timesStretchedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FormattingOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 403);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.timesStretchedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 120;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(600, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar1.Value = 120;
            // 
            // timesStretchedLabel
            // 
            this.timesStretchedLabel.Name = "timesStretchedLabel";
            this.timesStretchedLabel.Size = new System.Drawing.Size(99, 17);
            this.timesStretchedLabel.Text = "Times stretched:0";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 403);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormattingOptions,
            this.FontDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(140, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // FormattingOptions
            // 
            this.FormattingOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FormattingOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicsToolStripMenuItem,
            this.underlineToolStripMenuItem});
            this.FormattingOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormattingOptions.Image")));
            this.FormattingOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FormattingOptions.Name = "FormattingOptions";
            this.FormattingOptions.Size = new System.Drawing.Size(79, 22);
            this.FormattingOptions.Text = "Formatting";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.boldToolStripMenuItem.Text = "&Bold";
            // 
            // italicsToolStripMenuItem
            // 
            this.italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            this.italicsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.italicsToolStripMenuItem.Text = "&Italic";
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.underlineToolStripMenuItem.Text = "&Underline";
            // 
            // FontDropDown
            // 
            this.FontDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.sansSerifToolStripMenuItem});
            this.FontDropDown.Image = ((System.Drawing.Image)(resources.GetObject("FontDropDown.Image")));
            this.FontDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontDropDown.Name = "FontDropDown";
            this.FontDropDown.Size = new System.Drawing.Size(49, 22);
            this.FontDropDown.Text = "Fonts";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.timesNewRomanToolStripMenuItem.Text = "&TimesNewRoman";
            // 
            // sansSerifToolStripMenuItem
            // 
            this.sansSerifToolStripMenuItem.Name = "sansSerifToolStripMenuItem";
            this.sansSerifToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sansSerifToolStripMenuItem.Text = "&SansSerif";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // helpfulEssayWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "helpfulEssayWriter";
            this.Text = "Helpful essay writer";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FormattingOptions;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton FontDropDown;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sansSerifToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel timesStretchedLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.RichTextBox richTextBox;
    }
}

