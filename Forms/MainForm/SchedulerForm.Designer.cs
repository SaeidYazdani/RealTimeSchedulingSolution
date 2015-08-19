namespace Forms.MainForm
{
    partial class SchedulerForm
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
            this.schedulerControl1 = new CustomControls.SchedulerControl();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Location = new System.Drawing.Point(47, 13);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(151, 107);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            // 
            // SchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "SchedulerForm";
            this.Text = "SchedulerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.SchedulerControl schedulerControl1;
    }
}