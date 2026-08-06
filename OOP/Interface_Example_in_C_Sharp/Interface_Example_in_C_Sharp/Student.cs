using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Example_in_C_Sharp
{
    public class Student : IInformation
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public double CGPA { get; set; }

        public void ShowInformation()
        {
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("CGPA: " + CGPA);
        }
    }
}
