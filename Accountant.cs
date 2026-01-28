using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Accountant(string name) : Employee(45000, "Accountant", name), ISender, IEvaluated
    {
        private Accountant helpsAccountant;

        internal Accountant HelpsAccountant { get => helpsAccountant; set => helpsAccountant = value; }

        private void update(int salary, Employee employee)
        {
            this.setSalary(salary, employee);
            Console.WriteLine(employee.Name + " salary udpated to " +  salary);
        }

        private void send(string msg, List<Employee> employees)
        {
            employees.ForEach(e => { Console.WriteLine(e.Name + ", " + msg); });
        }

        public void doJob(int salary, Employee employee)
        {
            this.update(salary, employee);
        }

        public void doDelegatedJob(string msg, List<Employee> employees)
        {
            this.send(msg, employees);
        }
    }
}
