using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace CustomControls
{
    public class TaskControlAcceptedEventArgs : EventArgs
    {
        public List<Types.SingleTask> TasksList;

        public TaskControlAcceptedEventArgs(List<Types.SingleTask> tasks)
        {
            TasksList = tasks;
        }

    }
}
