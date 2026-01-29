using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Accountant(string name) : Employee(45000, "Accountant", name), IEvaluated, IAccountant
    {
        private IAccountant helpsAccountant;
        private IOwner helpsOwner;

        internal IAccountant HelpsAccountant { get => helpsAccountant; set => helpsAccountant = value; }
        internal IOwner HelpsOwner { get => helpsOwner; set => helpsOwner = value; }

        private void update(int salary, Employee employee)
        {
            this.setSalary(salary, employee);
            Console.WriteLine(employee.Name + " salary udpated to " +  salary);
        }

        public void doJob(int salary, Employee employee)
        {
            this.update(salary, employee);
        }
    }
}
