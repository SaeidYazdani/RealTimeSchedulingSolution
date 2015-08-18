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

        public int TaskCount = 0;
        public List<Types.Task> TasksList;

        public TaskControlAcceptedEventArgs(List<Types.Task> tasks, int count)
        {
            TasksList = tasks;
            TaskCount = count;
        }

    }
}
