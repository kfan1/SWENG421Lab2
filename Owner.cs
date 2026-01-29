using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Owner(string name) : Person(name, null, "Owner"), IOwner
    {
        private IManager helpsManager;

        internal IManager HelpsManager { get => helpsManager; set => helpsManager = value; }

        private void send(string msg, List<Employee> employees)
        {
            employees.ForEach(e => { Console.WriteLine(e.Name + ", " + msg); });
        }

        public void doJob(string msg, List<Employee> employees)
        {
            this.send(msg, employees);
        }
    }
}
