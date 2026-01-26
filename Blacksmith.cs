using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Blacksmith(string name, Task? task = null) : Employee(35000, "Blacksmith", name), IEvaluated
    {
        public Employee employee;
        public Task? task = task;

        public void perform(Blacksmith? blacksmith = null)
        {
            if(this.task != null)
            {
                Console.WriteLine(this.name + " is performing his task " + this.task.id);
            }
            if(this.employee != null)
            {
                Console.WriteLine(this.employee.name + " is helping " + this.name + " perform task " + this.task.id);
            }
            if(blacksmith != null && blacksmith.task != null)
            {
                Console.WriteLine(this.name + " is helping " + blacksmith.name + " perform task " + blacksmith.task.id);
            }
        }
    }
}
