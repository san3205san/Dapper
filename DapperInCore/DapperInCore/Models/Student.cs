using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperInCore.Models
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Address Address { get; set; }
    }
}
