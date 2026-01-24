using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal abstract class Employee(int salary, string title, string name) : Person(name, null, title)
    {
        private int salary = salary;

        protected void setSalary(int salary, Employee employee)
        {
            employee.salary = salary;
        }

        public int getSalary()
        {
            return salary; 
        }
    }
}
