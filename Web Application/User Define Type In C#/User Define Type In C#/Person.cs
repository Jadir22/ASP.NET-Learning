using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User_Define_Type_In_C_
{
    [Serializable]
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;

            return fullName;
        }
    }
}