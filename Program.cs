using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeOOP
{
    public class main
    {
        static void Main(string[] args)
        {
            College college = new College("Unifoa");
            
            Student student = new Student(001, "james", 25,"james@email.com" );
            Student student2 = new Student(002, "maikao", 45, "maikao@email.com");
            Course couse = new Course(23, "Engenharia");

            college.AddCourse(couse);

            college.AddStudent(student);
            college.AddStudent(student2);

            Console.WriteLine($"Instituição: {college.College_Name}");
            college.DisplayStudents();
            college.DisplayCourses();

            Console.ReadLine();




        }

    }

    
}
