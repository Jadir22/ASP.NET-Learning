using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Example_in_C_Sharp
{
    public class Department : IInformation
    {
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }

        public void ShowInformation()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("Department Head: " + DepartmentHead);
        }
    }
}
