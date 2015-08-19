using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Types;

namespace CustomControls
{
    public partial class SchedulerControl : Control
    {

        private TaskSet _taskSet;

        public SchedulerControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            //pen 1
            Pen p = new Pen(Color.Red);
            p.Brush = new SolidBrush(Color.Blue);

            //pen for text
            Pen tPen = new Pen(Color.Green);
            tPen.Brush = new SolidBrush(Color.Green);

            if (_taskSet == null)
            {
                g.DrawString("NO SCHEDULE", this.Font, tPen.Brush, 10,10);
            }
            else
            {
                g.DrawString("WE HAVE SCHEDULE", this.Font, tPen.Brush, 10, 10);
            }
        }

        public void UpdateTaskSet(TaskSet ts)
        {
            _taskSet = ts;
            this.Invalidate();
        }
    }
}
