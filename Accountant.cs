using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Accountant(string name) : Employee(45000, "Accountant", name)
    {
        public void update(int salary, Employee employee)
        {
            this.setSalary(salary, employee);
            Console.WriteLine(this.name + " updated " + employee.name + " salary to " +  salary);
        }

        public void requestHelp(Accountant accountant)
        {
            Console.WriteLine(this.name + " requests help from " + accountant.name);
        }
    }
}
