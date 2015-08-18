namespace CustomControls
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbPeriod = new System.Windows.Forms.MaskedTextBox();
            this.mtbExecution = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Execution";
            // 
            // mtbPeriod
            // 
            this.mtbPeriod.Location = new System.Drawing.Point(59, 4);
            this.mtbPeriod.Mask = "999";
            this.mtbPeriod.Name = "mtbPeriod";
            this.mtbPeriod.Size = new System.Drawing.Size(100, 22);
            this.mtbPeriod.TabIndex = 4;
            // 
            // mtbExecution
            // 
            this.mtbExecution.Location = new System.Drawing.Point(269, 5);
            this.mtbExecution.Mask = "999";
            this.mtbExecution.Name = "mtbExecution";
            this.mtbExecution.Size = new System.Drawing.Size(100, 22);
            this.mtbExecution.TabIndex = 5;
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbExecution);
            this.Controls.Add(this.mtbPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(372, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPeriod;
        private System.Windows.Forms.MaskedTextBox mtbExecution;
    }
}
