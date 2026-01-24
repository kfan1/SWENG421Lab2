using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Manager(string name) : Employee(50000, "Manager", name), IEvaluator
    {
        public void evaluate(Accountant employee, int scale)
        {
            Console.WriteLine(this.name + " evaluated " + employee.name + " Likert score: " + scale);
        }

        public void evaluate(Blacksmith employee, int scale)
        {
            Console.WriteLine(this.name + " evaluated " + employee.name + " Likert score: " + scale);
        }

        public void requestHelp(IEvaluator evaluator)
        {
            if (evaluator is Manager)
            {
                Manager? manager = evaluator as Manager;
                Console.WriteLine(this.name + " requests help from " + manager.name + " with evaluation");
            }
            else
            {
                Owner? owner = evaluator as Owner;
                Console.WriteLine(this.name + " requests help from " + owner.name + " with evaluation");
            }
        }
    }
}
