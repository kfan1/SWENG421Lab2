using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal abstract class Employee(int salary, string title, string name) : Person(name, null, title)
    {
        private int salary = salary;

        public int Salary { get => salary; private set => salary = value; }

        protected void setSalary(int salary, Employee employee)
        {
            employee.Salary = salary;
        }
    }
}
