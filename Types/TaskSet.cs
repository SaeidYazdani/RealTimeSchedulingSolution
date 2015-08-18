using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class TaskSet
    {
        public List<Task> TaskList;
        public int HyperPeriod;

        /// <summary>
        /// 
        /// </summary>
        public TaskSet()
        {
            TaskList = new List<Task>();
            
        }

        /// <summary>
        /// Create from a set of alrady defined tasks
        /// </summary>
        /// <param name="tasks"></param>
        public TaskSet(List<Task> tasks)
        {
            TaskList = tasks;
            HyperPeriod = GetHyperperiode();
        }

        public void AddTask(Task task)
        {
            ///TODO CHECK FOR UNIQUENESS
            TaskList.Add(task);
            HyperPeriod = GetHyperperiode();
        }

        public bool RemoveTask(Task task)
        {
            //TODO This method should be implemented by ostad milad
            throw new NotImplementedException("This method has not been yet implemented by OSTAD MILAD");
        }

        public bool RemoveTask(double e, double p)
        {
            //TODO This method should be implemented by ostad milad
            throw new NotImplementedException("This method has not been yet implemented by OSTAD MILAD");
        }

        public int GetHyperperiode()
        {
            //TODO check if we have 1 job return already....
            if (TaskList.Count == 1)
            {
                HyperPeriod = TaskList[0].Period;
            }

            int count = TaskList.Count;
            
            int lcm = determineLCM(TaskList[count].Period, TaskList[count - 1].Period);
            count--;

            while (count != 0)
            {
                lcm = determineLCM(TaskList[count].Period, TaskList[count - 1].Period);
                count--;
            }

             return lcm;
        }

        private static int determineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }
    }
}
