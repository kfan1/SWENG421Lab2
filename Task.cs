using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    /// <summary>
    /// Tasks to be assigned to blacksmiths
    /// </summary>
    /// <param name="id">Task id/name</param>
    internal class Task(string id)
    {
        private string id = id;
        private string dueDate;
        private string description;

        public string Id { get => id; set => id = value; }
    }
}
