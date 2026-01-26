using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Owner(string name) : Person(name, null, "Owner"), ISender, IEvaluator
    {
        public ISender sender;

        public void send(string msg, List<Employee> employees)
        {
            if(sender != null)
            {
                Person person = sender as Person;
                Console.WriteLine(person.name + " sends message:");
            } else
            {
                Console.WriteLine(this.name + " sends message:");
            }
            employees.ForEach(e => { Console.WriteLine(e.name + ", " + msg); });
        }
    }
}
