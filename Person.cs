using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal abstract class Person(string name, int? age, string title)
    {
        public string? name = name;
        public int? age = age;
        public string? title = title;
    }
}
