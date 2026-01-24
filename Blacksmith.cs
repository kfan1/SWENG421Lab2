using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Blacksmith(string name, Task? task = null) : Employee(35000, "Blacksmith", name)
    {
        Task? task = task;

        public void perform(Blacksmith? blacksmith = null)
        {
            if(this.task != null)
            {
                Console.WriteLine(this.name + " is performing his task " + this.task.taskName);
            }
            if(blacksmith != null && blacksmith.task != null)
            {
                Console.WriteLine(this.name + " is helping " + blacksmith.name + " perform task " + blacksmith.task.taskName);
            }
        }

        public void requestHelp(Employee employee)
        {
            Console.WriteLine(this.name + " requests help from " + employee.name + " with " + this.task.taskName);
        }
    }
}
