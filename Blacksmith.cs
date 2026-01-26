using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Blacksmith(string name, Task? task = null) : Employee(35000, "Blacksmith", name), IEvaluated
    {
        private Employee employee;
        private Task? task = task;

        internal Employee Employee { get => employee; set => employee = value; }
        internal Task? Task { get => task; set => task = value; }

        public void perform(Blacksmith? blacksmith = null)
        {
            if(this.Task != null)
            {
                Console.WriteLine(this.Name + " is performing his task " + this.Task.id);
            }
            if(this.Employee != null)
            {
                Console.WriteLine(this.Employee.Name + " is helping " + this.Name + " perform task " + this.Task.id);
            }
            if(blacksmith != null && blacksmith.Task != null)
            {
                Console.WriteLine(this.Name + " is helping " + blacksmith.Name + " perform task " + blacksmith.Task.id);
            }
        }
    }
}
