using DotNetMEFCodeFirst.Model;
using System;
using System.Diagnostics;

namespace DotNetMEFCodeFirst.Controller
{
    class SchoolController
    {
        public void PopulateStudents()
        {
            using (var ctx = new SchoolContext())
            {
                var stud1 = new Student()
                {
                    Name = "Alessio Saltarin",
                    DateBirth = new DateTime(1970, 8, 26)
                };
                var stud2 = new Student()
                {
                    Name = "Elena Zambrelli",
                    DateBirth = new DateTime(1975, 12, 13)
                };
                var stud3= new Student()
                {
                    Name = "Dana Patrick",
                    DateBirth = new DateTime(1980, 10, 6)
                };

                ctx.Students.Add(stud1);
                ctx.Students.Add(stud2);
                ctx.Students.Add(stud3);

                ctx.SaveChanges();
            }
        }

        public void PopulateCourses()
        {
            using (var ctx = new SchoolContext())
            {
                var mefCourse = new Course()
                {
                    Name = "Entity Framework"
                };
                var nodejsCourse = new Course()
                {
                    Name = "Node.js"
                };

                ctx.Courses.Add(mefCourse);
                ctx.Courses.Add(nodejsCourse);

                ctx.SaveChanges();
            }
        }

        public void AssociateStudentsToCourses()
        {

            var randomSeed = new Random();

            using (var ctx = new SchoolContext())
            {

                var mefCourse = ctx.Courses.Find(1);
                Debug.Assert(mefCourse != null);
                var nodeJS = ctx.Courses.Find(2);
                Debug.Assert(nodeJS != null);

                foreach (var student in ctx.Students)
                {
                    var courseSelection = randomSeed.Next(100);
                    if (courseSelection < 50)
                    {
                        Console.WriteLine(" Student " + student.Name + " will follow " + mefCourse.Name);
                        student.Course = mefCourse;
                    }
                    else
                    {
                        Console.WriteLine(" Student " + student.Name + " will follow " + nodeJS.Name);
                        student.Course = nodeJS;
                    }
                }

                ctx.SaveChanges();

            }
        }
    }
}
