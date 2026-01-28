using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Blacksmith(string name, Task? task = null) : Employee(35000, "Blacksmith", name), IEvaluated
    {
        private Task? task = task;

        internal Task? Task { get => task; set => task = value; }

        private void perform()
        {
            if(this.Task != null)
            {
                Console.WriteLine("performing task " + this.Task.Id);
            }
            if(this.HelpsBlacksmith != null && this.HelpsBlacksmith.Task != null)
            {
                Console.WriteLine("performing task " + this.HelpsBlacksmith.Task.Id);
            }
        }

        public void doJob()
        {
            this.perform();
        }
    }
}
