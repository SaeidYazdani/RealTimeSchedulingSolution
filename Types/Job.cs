using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Job
    {
        public int ExecutionTime;
        public int ReleaseTime;
        public int Deadline;

        public Job(int e, int r, int d)
        {
            ExecutionTime = e;
            ReleaseTime = r;
            Deadline = d;
        }
    }
}
