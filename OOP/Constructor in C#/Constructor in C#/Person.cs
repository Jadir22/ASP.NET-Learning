using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_in_C_
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string firstName, string lastName)
        {
            Firstname = firstName;
            Lastname = lastName;
        }

        public string GetFullName()
        {
            return Firstname+" "+Lastname;
        }
    }
}
