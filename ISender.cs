using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal interface ISender
    {
        public abstract void doDelegatedJob(string msg, List<Employee> employees);
    }
}
