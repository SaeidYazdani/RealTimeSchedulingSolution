using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.MainForm;
using Types;

namespace Forms
{
    public partial class SplashScreenForm : Form
    {

        private List<SingleTask> _ts ;

        public SplashScreenForm()
        {
            InitializeComponent();

            comboBoxOperation.Items.Add("+");
            comboBoxOperation.Items.Add("-");
            comboBoxOperation.Items.Add("*");
            comboBoxOperation.Items.Add("/");

            comboBoxOperation.SelectedIndex = 0;

            GhaforButton.Click += delegate
            {

                MessageBox.Show("DAST AKHONDI IS UPSET!!!!!");
            }; 

     



        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void showScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulerForm sf = new SchedulerForm();
            sf.ShowDialog();
        }
    }
}
