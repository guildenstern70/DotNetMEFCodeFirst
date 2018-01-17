using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetMEFCodeFirst.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        public Course Course { get; set; }
    }
}
