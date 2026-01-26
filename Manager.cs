using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    internal class Manager(string name) : Employee(50000, "Manager", name), ISender, IEvaluator
    {
        private IEvaluator evaluator;

        internal IEvaluator Evaluator { get => evaluator; set => evaluator = value; }

        public void evaluate(IEvaluated evaluated, int scale)
        {
            Person person = evaluated as Person;
            if(Evaluator != null)
            {
                Person evaluatorPerson = this.Evaluator as Person;
                Console.WriteLine(evaluatorPerson.Name + " evaluated " + person.Name + " Likert score: " + scale);
            } else
            {
                Console.WriteLine(this.Name + " evaluated " + person.Name + " Likert score: " + scale);
            }
            
        }
    }
}
