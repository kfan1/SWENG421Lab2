using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{

    /// <summary>
    /// The Accountant class
    /// This class is able to update the salary for other employees
    /// Extends Employee class and implements IEvaluated and IAccountant
    /// </summary>
    /// <param name="name">Name of the accountant</param>
    internal class Accountant(string name) : Employee(45000, "Accountant", name), IEvaluated, IAccountant
    {
        // Accountant can help another accountant or owner with their task
        private IAccountant helpsAccountant;
        private IOwner helpsOwner;

        // Getter setters for instance variables
        internal IAccountant HelpsAccountant { get => helpsAccountant; set => helpsAccountant = value; }
        internal IOwner HelpsOwner { get => helpsOwner; set => helpsOwner = value; }

        /// <summary>
        /// Update employee salary
        /// </summary>
        /// <param name="salary">New updated salary</param>
        /// <param name="employee">Employee who's salary is being updated</param>
        private void update(int salary, Employee employee)
        {
            this.setSalary(salary, employee);
            Console.WriteLine(employee.Name + " salary udpated to " +  salary);
        }

        /// <summary>
        /// Do the accountant's job
        /// </summary>
        /// <param name="salary">New updated salary</param>
        /// <param name="employee">Employee who's salary is being updated</param>
        public void doJob(int salary, Employee employee)
        {
            this.update(salary, employee);
        }
    }
}
