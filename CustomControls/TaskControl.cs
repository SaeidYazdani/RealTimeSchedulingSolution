using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Types;

namespace CustomControls
{
    public partial class TaskControl : UserControl
    {
        public TaskControl()
        {
            InitializeComponent();
        }

        public SingleTask GetTask()
        {
            //TODO take care of data validation

            return new SingleTask(Convert.ToInt32(mtbExecution.Text), Convert.ToInt32(mtbExecution.Text));
        }
    }


}
