using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using Types;

namespace Forms.MainForm
{
    public partial class AboutForm : Form
    {
  

        // added
        public List<SingleTask> Ts = new List<SingleTask>();

        public AboutForm()
        {
            InitializeComponent();

            taskTakerControl1.OnAccept += handleAcceptButton;
        }



        private void handleAcceptButton(object s, TaskControlAcceptedEventArgs e)
        {
            List<SingleTask> tasks = e.TasksList;

            Ts = e.TasksList;

           

            this.Close();
        }
    }
}
