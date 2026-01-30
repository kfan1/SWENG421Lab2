using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Abstract Employee class
    /// All employees extend from this class
    /// Extends the person class
    /// </summary>
    /// <param name="salary">Salary of employee</param>
    /// <param name="title">Title for employee</param>
    /// <param name="name">Name of employee</param>
    internal abstract class Employee(int salary, string title, string name) : Person(name, null, title)
    {
        private int salary = salary;
        // All employees can help blacksmiths with their task
        private Blacksmith helpsBlacksmith;

        // Getter setters for instance variables, get salary is public, set salary is private
        public int Salary { get => salary; private set => salary = value; }
        internal Blacksmith HelpsBlacksmith { get => helpsBlacksmith; set => helpsBlacksmith = value; }

        /// <summary>
        /// Set's the employee salary, protected so only can be called inside of subclasses
        /// </summary>
        /// <param name="salary">New updated salary</param>
        /// <param name="employee">Employee who's salary is being updated</param>
        protected void setSalary(int salary, Employee employee)
        {
            employee.Salary = salary;
        }
    }
}
