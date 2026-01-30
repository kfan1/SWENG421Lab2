using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    /// <summary>
    /// Owner class
    /// The owner can send messages to the other employees
    /// Extends person and implements IOwner
    /// </summary>
    /// <param name="name"></param>
    internal class Owner(string name) : Person(name, null, "Owner"), IOwner
    {
        // The owner can help a manager
        private IManager helpsManager;

        internal IManager HelpsManager { get => helpsManager; set => helpsManager = value; }

        /// <summary>
        /// Send a message to employees
        /// </summary>
        /// <param name="msg">Message to employees</param>
        /// <param name="employees">Employees to recieve the message</param>
        private void send(string msg, List<Employee> employees)
        {
            employees.ForEach(e => { Console.WriteLine(e.Name + ", " + msg); });
        }

        /// <summary>
        /// Do the owner's job
        /// </summary>
        /// <param name="msg">Message to employees</param>
        /// <param name="employees">Employees to recieve the message</param>
        public void doJob(string msg, List<Employee> employees)
        {
            this.send(msg, employees);
        }
    }
}
