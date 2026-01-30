using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Blacksmith Class
    /// This class is able to perform assigned tasks
    /// Extends Employee and implements IEvaluated
    /// </summary>
    /// <param name="name">Name of blacksmith</param>
    /// <param name="task">Optional task assigned to blacksmith</param>
    internal class Blacksmith(string name, Task? task = null) : Employee(35000, "Blacksmith", name), IEvaluated
    {
        // Task assigned to blacksmith
        private Task? task = task;

        // Getter setters for instance variables
        internal Task? Task { get => task; set => task = value; }

        /// <summary>
        /// Perform the assigned task and help any other blacksmith with their task
        /// </summary>
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

        /// <summary>
        /// Do the blacksmith's job
        /// </summary>
        public void doJob()
        {
            this.perform();
        }
    }
}
