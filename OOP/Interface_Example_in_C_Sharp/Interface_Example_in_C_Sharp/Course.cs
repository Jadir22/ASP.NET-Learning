using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Example_in_C_Sharp
{
    public class Course : IInformation
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int Credit { get; set; }

        public void ShowInformation()
        {
            Console.WriteLine("Course Code: " + CourseCode);
            Console.WriteLine("Course Title: " + CourseTitle);
            Console.WriteLine("Credit: " + Credit);
        }
    }
}
