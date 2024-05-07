using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CollegeOOP
{
    internal class College
    {
        private string college_name;
        private List<Course> courses;
        private List<Student> students;

        public string College_Name
        {
            get { return college_name; }
            set { college_name = value; }
        }
        

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        //construct method
        public College(string college_name)
        {
            this.college_name = college_name;
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        //COURSE
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void RemoveCourse(Course course) 
        { 
            courses.Remove(course);
        }

        public void DisplayCourses()
        {
            Console.WriteLine("Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.Id}, Name: {course.Name}");
            }
        }


        //STUDENT
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
            }
        }
    }

    

}
