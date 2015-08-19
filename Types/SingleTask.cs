using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class SingleTask
    {
        public int ExecutionTime;
        public int Period;

        public SingleTask(int executionTime, int period)
        {
            ExecutionTime = executionTime;
            Period = period;
        }
    }
}
