using DotNetMEFCodeFirst.Controller;
using System;

namespace DotNetMEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var schoolController = new SchoolController();
            Console.WriteLine("Creating students...");
            schoolController.PopulateStudents();
            Console.WriteLine("Creating courses...");
            schoolController.PopulateCourses();
            Console.WriteLine("Associating students-courses...");
            schoolController.AssociateStudentsToCourses();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
