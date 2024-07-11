using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assosiation.Aggregation
{
    internal class Department
    {

        public int id { get; set; }
        public string? Name { get; set; }

        public Employee[]? Employees { get; set; }

        public Department(string name)
        {
            Name = name;
        }
        public Department(string name, Employee[] employees)
        {
            Name = name;
            Employees = employees;
        }

    }
}
