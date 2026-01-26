using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Owner(string name) : Person(name, null, "Owner"), ISender, IEvaluator
    {
        private ISender sender;

        internal ISender Sender { get => sender; set => sender = value; }

        private void send(string msg, List<Employee> employees)
        {
            if(Sender != null)
            {
                Person person = Sender as Person;
                Console.WriteLine(person.Name + " sends message:");
            } else
            {
                Console.WriteLine(this.Name + " sends message:");
            }
            employees.ForEach(e => { Console.WriteLine(e.Name + ", " + msg); });
        }

        public void doJob(string msg, List<Employee> employees)
        {
            this.send(msg, employees);
        }
    }
}
