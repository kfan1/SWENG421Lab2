using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Manager interface
    /// </summary>
    internal interface IManager
    {
        /// <summary>
        /// Do the manager's job
        /// </summary>
        /// <param name="evaluated">The employee being evaluated</param>
        /// <param name="scale">The evaluation score</param>
        public abstract void doJob(IEvaluated evaluated, int scale);
    }
}
