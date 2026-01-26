using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Accountant(string name) : Employee(45000, "Accountant", name), ISender, IEvaluated
    {
        private Accountant accountantDelegatee;

        internal Accountant AccountantDelegatee { get => accountantDelegatee; set => accountantDelegatee = value; }

        public void update(int salary, Employee employee)
        {
            this.setSalary(salary, employee);
            Console.WriteLine(this.Name + " updated " + employee.Name + " salary to " +  salary);
        }
    }
}
