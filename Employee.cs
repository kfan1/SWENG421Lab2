using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal abstract class Employee(int salary, string title, string name) : Person(name, null, title)
    {
        private int salary = salary;
        private Blacksmith helpsBlacksmith;

        public int Salary { get => salary; private set => salary = value; }
        internal Blacksmith HelpsBlacksmith { get => helpsBlacksmith; set => helpsBlacksmith = value; }

        protected void setSalary(int salary, Employee employee)
        {
            employee.Salary = salary;
        }
    }
}
