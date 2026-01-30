using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Abstract person class
    /// All people extend this class
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="age">Age of person</param>
    /// <param name="title">Title of person</param>
    internal abstract class Person(string name, int? age, string title)
    {
        private string? name = name;
        private int? age = age;
        private string? title = title;

        public string? Name { get => name; set => name = value; }
    }
}
