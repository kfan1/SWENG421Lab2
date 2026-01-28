using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal interface IManager
    {
        public abstract void doJob(IEvaluated evaluated, int scale);
    }
}
