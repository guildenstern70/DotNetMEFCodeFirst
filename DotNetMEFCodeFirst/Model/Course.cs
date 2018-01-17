using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetMEFCodeFirst.Model
{
    public class Course
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
