using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    /// <summary>
    /// Manager class
    /// Manager can evaluate employees
    /// Extends employees and implements IManager
    /// </summary>
    /// <param name="name">Name of manager</param>
    internal class Manager(string name) : Employee(50000, "Manager", name), IManager
    {
        // Manager can help another manager or the owner
        private IManager helpsManager;
        private IOwner helpsOwner;

        // Getter setters for instance variables
        internal IManager HelpsManager { get => helpsManager; set => helpsManager = value; }
        internal IOwner HelpsOwner { get => helpsOwner; set => helpsOwner = value; }

        /// <summary>
        /// Evaluate an employee
        /// </summary>
        /// <param name="evaluated">The employee being evaluated</param>
        /// <param name="scale">The evaluation score</param>
        private void evaluate(IEvaluated evaluated, int scale)
        {
            Person person = evaluated as Person;
            Console.WriteLine(person.Name + " Likert score: " + scale);
        }

        /// <summary>
        /// Do the manager's job
        /// </summary>
        /// <param name="evaluated">The employee being evaluated</param>
        /// <param name="scale">The evaluation score</param>
        public void doJob(IEvaluated evaluated, int scale)
        {
            this.evaluate(evaluated, scale);
        }
    }
}
