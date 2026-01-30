using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Accountant interface
    /// </summary>
    internal interface IAccountant
    {
        /// <summary>
        /// Do the accountant's job
        /// </summary>
        /// <param name="salary">New updated salary</param>
        /// <param name="employee">Employee who's salary is being updated</param>
        public abstract void doJob(int salary, Employee employee);
    }
}
