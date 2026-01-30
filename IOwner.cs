using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Owner interface
    /// </summary>
    internal interface IOwner
    {
        /// <summary>
        /// Do the owner's job
        /// </summary>
        /// <param name="msg">Message to employees</param>
        /// <param name="employees">Employees to recieve the message</param>
        public abstract void doJob(string msg, List<Employee> employees);
    }
}
