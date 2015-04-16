using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            string last;
            string birthdate;
            GetStudentInfo(out first, out last, out birthdate);
            PrintStudentDetails(first, last, birthdate);

            string teacher;
            string course;
            string program;
            string degree;
            GetSchoolDetails(out teacher, out course, out program, out degree);
            PrintSchoolDetails(teacher, course, program, degree);
        }
        // Ask user for student information
        static void GetStudentInfo(out string first, out string last, out string birthdate)
        {
            Console.WriteLine("First name: ");
            first = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            last = Console.ReadLine();
            Console.WriteLine("Birthdate(optional): ");
            birthdate = Console.ReadLine();

           
        }
        // Ask for school details
        static void GetSchoolDetails(out string teacher, out string course, out string program, out string degree)
        {
            Console.WriteLine("Teacher: ");
            teacher = Console.ReadLine();
            Console.WriteLine("Course: ");
            course = Console.ReadLine();
            Console.WriteLine("Program: ");
            program = Console.ReadLine();
            Console.WriteLine("Degree: ");
            degree = Console.ReadLine();
        }
        // Displays to screen the students information
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            if (birthday == "")
                Console.WriteLine("Hello, {0} {1}.", first, last);
            else
                Console.WriteLine("Hello, {0} {1}.  Your bithday is {2}", first, last, birthday);
        }
        // Display to screen the school details
        static void PrintSchoolDetails(string teacher, string course, string program, string degree)
        {
            Console.WriteLine("Teacher: {0}\nCourse: {1}\n Program: {2}\n Degree: {3}\n", teacher, course, program, degree);
        }

    }
}
