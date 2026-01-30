using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// The company class
    /// Contains all the employees and the owner
    /// </summary>
    internal class Company
    {
        // List of all the employees and the owner
        private List<Employee> Employees = new List<Employee>();
        private Owner? Owner;

        // Getter setters for instance variables
        internal List<Employee> Employees1 { get => Employees; set => Employees = value; }
        internal Owner? Owner1 { get => Owner; set => Owner = value; }
    }
}
