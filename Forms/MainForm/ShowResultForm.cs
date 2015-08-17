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
    public partial class ShowResultForm : Form
    {
        public ShowResultForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        public ShowResultForm(int result)
        {
            InitializeComponent();
            labelResult.Text = result.ToString();
        }
    }
}
