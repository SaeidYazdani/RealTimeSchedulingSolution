﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class TaskTakerControl : UserControl
    {
        //this is how to declare our own event
        //Creating a custom event for when button accept is clicked
        public delegate void AcceptButtonHandler(object sender, TaskControlAcceptedEventArgs e);
        public event AcceptButtonHandler OnAccept;

        public TaskTakerControl()
        {
            InitializeComponent();

            buttonMore.Click += delegate
            {
                TaskControl tk = new TaskControl();
                tk.Name = "tk" + panel1.Controls.Count + 1;
                tk.Size = new Size(panel1.Controls[0].Width, panel1.Controls[0].Height);

                //calculate Location Y
                int y = (panel1.Controls.Count * panel1.Controls[0].Height) + panel1.Controls[0].Height;

                tk.Location = new Point(panel1.Controls[0].Location.X, y);

                panel1.Controls.Add(tk);


                // how to check if a is TaskContol
                // Control a = panel1.Controls[0];
                //if (a is TaskControl)
            };
            //TODO event for cancel
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(Control c in panel1.Controls)
            {
                if(c is TaskControl)
                {
                      count++;
                }
            }

            TaskControlAcceptedEventArgs  te = new TaskControlAcceptedEventArgs(null, count);

            OnAccept(this, te);
        }
    }
}
