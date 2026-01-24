using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Owner(string name) : Person(name, null, "Owner"), IEvaluator
    {
        public void send(string msg, List<Employee> employees)
        {
            employees.ForEach(e => { Console.WriteLine(e.name + ", " + msg); });
        }

        public void delegates(Manager manager)
        {
            Console.WriteLine("Owner duty delegated to " + manager.name);
        }

        public void evaluate(Accountant employee, int scale)
        {
            Console.WriteLine(this.name + " evaluated " + employee.name + " Likert score: " + scale);
        }

        public void evaluate(Blacksmith employee, int scale)
        {
            Console.WriteLine(this.name + " evaluated " + employee.name + " Likert score: " + scale);
        }
    }
}
