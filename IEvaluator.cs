using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal interface IEvaluator
    {
        public void evaluate(Accountant employee, int scale);
        public void evaluate(Blacksmith employee, int scale);
    }
}
