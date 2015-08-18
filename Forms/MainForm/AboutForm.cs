using CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.MainForm
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            taskTakerControl1.OnAccept += handleAcceptButton;
        }

        private void handleAcceptButton(object s, TaskControlAcceptedEventArgs e)
        {
            MessageBox.Show(e.TaskCount.ToString());
            this.Close();
        }
    }
}
