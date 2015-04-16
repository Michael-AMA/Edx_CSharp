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
            GetStudentInfo();
            try
            {
                ValidateStudentInfo();
            }
            catch(NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }
        // Get the students inforamtion
        static void GetStudentInfo()
        {
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName  = Console.ReadLine();
            Console.WriteLine("Birthday: ");
            string birthday = Console.ReadLine();
            string teacher;
            string course;
            string program;
            string degree;
            GetSchoolInfo(out teacher, out course, out program, out degree);
            PrintStudentInfo(firstName, lastName, birthday, teacher, course, program, degree);

        }

        // Get School information
        static void GetSchoolInfo(out string teacher, out string course, out string program, out string degree)
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

        // Print to the screen ALL student information
        static void PrintStudentInfo(string first, string last, string birthday, string teacher, string course, string program, string degree)
        {
            Console.WriteLine("Name: {0} {1}", first, last);
            Console.WriteLine("Birthdate: {0}", birthday);
            Console.WriteLine("Teacher: {0}", teacher);
            Console.WriteLine("Course: {0}", course);
            Console.WriteLine("Program: {0}", program);
            Console.WriteLine("Degree: {0}", degree);
        }
        
        static void ValidateStudentInfo()
        {
            throw new NotImplementedException();
        }
    }
}
