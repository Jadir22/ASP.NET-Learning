using Interface_Example_in_C_Sharp;

Department department = new Department();

department.DepartmentName = "Computer Science";
department.DepartmentHead = "Dr. Rahman";


Course course = new Course();

course.CourseCode = "CSE-101";
course.CourseTitle = "Introduction to Programming";
course.Credit = 3;


Student student = new Student();

student.StudentId = "23-50150-1";
student.StudentName = "Jadir";
student.CGPA = 3.50;


Console.WriteLine("Department Information");
department.ShowInformation();

Console.WriteLine();


Console.WriteLine("Course Information");
course.ShowInformation();

Console.WriteLine();


Console.WriteLine("Student Information");
student.ShowInformation();

Console.ReadLine();