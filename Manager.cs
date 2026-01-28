using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Manager(string name) : Employee(50000, "Manager", name), ISender
    {
        private Manager helpsManager;

        internal Manager HelpsManager { get => helpsManager; set => helpsManager = value; }

        private void evaluate(IEvaluated evaluated, int scale)
        {
            Person person = evaluated as Person;
            Console.WriteLine(person.Name + " Likert score: " + scale);
        }

        private void send(string msg, List<Employee> employees)
        {
            employees.ForEach(e => { Console.WriteLine(e.Name + ", " + msg); });
        }

        public void doJob(IEvaluated evaluated, int scale)
        {
            this.evaluate(evaluated, scale);
        }

        public void doDelegatedJob(string msg, List<Employee> employees)
        {
            this.send(msg, employees);
        }
    }
}
