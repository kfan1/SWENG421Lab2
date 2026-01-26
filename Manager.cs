using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Manager(string name) : Employee(50000, "Manager", name), ISender, IEvaluator
    {
        public IEvaluator evaluator;

        public void evaluate(IEvaluated evaluated, int scale)
        {
            Person person = evaluated as Person;
            if(evaluator != null)
            {
                Person evaluatorPerson = this.evaluator as Person;
                Console.WriteLine(evaluatorPerson.name + " evaluated " + person.name + " Likert score: " + scale);
            } else
            {
                Console.WriteLine(this.name + " evaluated " + person.name + " Likert score: " + scale);
            }
            
        }
    }
}
