using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal abstract class Person(string name, int? age, string title)
    {
        private string? name = name;
        private int? age = age;
        private string? title = title;

        public string? Name { get => name; set => name = value; }
    }
}
