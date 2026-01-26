using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Company
    {
        private List<Employee> Employees = new List<Employee>();
        private Owner? Owner;

        internal List<Employee> Employees1 { get => Employees; set => Employees = value; }
        internal Owner? Owner1 { get => Owner; set => Owner = value; }
    }
}
