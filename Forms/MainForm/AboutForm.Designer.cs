namespace Forms.MainForm
{
    partial class AboutForm
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
            this.taskTakerControl1 = new CustomControls.TaskTakerControl();
            this.SuspendLayout();
            // 
            // taskTakerControl1
            // 
            this.taskTakerControl1.Location = new System.Drawing.Point(13, 13);
            this.taskTakerControl1.Name = "taskTakerControl1";
            this.taskTakerControl1.Size = new System.Drawing.Size(471, 440);
            this.taskTakerControl1.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 463);
            this.Controls.Add(this.taskTakerControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.TaskTakerControl taskTakerControl1;
    }
}