namespace Forms
{
    partial class SplashScreenForm
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
            this.textBoxNumA = new System.Windows.Forms.TextBox();
            this.textBoxNumB = new System.Windows.Forms.TextBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxResults = new System.Windows.Forms.TextBox();
            this.GhaforButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumA
            // 
            this.textBoxNumA.Location = new System.Drawing.Point(16, 37);
            this.textBoxNumA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumA.Name = "textBoxNumA";
            this.textBoxNumA.Size = new System.Drawing.Size(216, 22);
            this.textBoxNumA.TabIndex = 0;
            // 
            // textBoxNumB
            // 
            this.textBoxNumB.Location = new System.Drawing.Point(17, 70);
            this.textBoxNumB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumB.Name = "textBoxNumB";
            this.textBoxNumB.Size = new System.Drawing.Size(215, 22);
            this.textBoxNumB.TabIndex = 1;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(17, 137);
            this.buttonProcess.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(216, 28);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "DO THE RIGHT THING";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.ButtonProcess_Click);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(17, 103);
            this.comboBoxOperation.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(215, 24);
            this.comboBoxOperation.TabIndex = 3;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(17, 278);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(100, 28);
            this.buttonHistory.TabIndex = 4;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textboxResults
            // 
            this.textboxResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxResults.Location = new System.Drawing.Point(241, 37);
            this.textboxResults.Margin = new System.Windows.Forms.Padding(4);
            this.textboxResults.Multiline = true;
            this.textboxResults.Name = "textboxResults";
            this.textboxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxResults.Size = new System.Drawing.Size(573, 490);
            this.textboxResults.TabIndex = 6;
            // 
            // GhaforButton
            // 
            this.GhaforButton.Location = new System.Drawing.Point(17, 172);
            this.GhaforButton.Name = "GhaforButton";
            this.GhaforButton.Size = new System.Drawing.Size(215, 81);
            this.GhaforButton.TabIndex = 7;
            this.GhaforButton.Text = "dastakhondi";
            this.GhaforButton.UseVisualStyleBackColor = true;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.GhaforButton);
            this.Controls.Add(this.textboxResults);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.textBoxNumB);
            this.Controls.Add(this.textBoxNumA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(847, 580);
            this.Name = "SplashScreenForm";
            this.Text = "SplashScreenForm";
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumA;
        private System.Windows.Forms.TextBox textBoxNumB;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textboxResults;
        private System.Windows.Forms.Button GhaforButton;
    }
}

