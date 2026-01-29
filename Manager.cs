using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Manager(string name) : Employee(50000, "Manager", name), IManager
    {
        private IManager helpsManager;
        private IOwner helpsOwner;

        internal IManager HelpsManager { get => helpsManager; set => helpsManager = value; }
        internal IOwner HelpsOwner { get => helpsOwner; set => helpsOwner = value; }

        private void evaluate(IEvaluated evaluated, int scale)
        {
            Person person = evaluated as Person;
            Console.WriteLine(person.Name + " Likert score: " + scale);
        }

        public void doJob(IEvaluated evaluated, int scale)
        {
            this.evaluate(evaluated, scale);
        }
    }
}
