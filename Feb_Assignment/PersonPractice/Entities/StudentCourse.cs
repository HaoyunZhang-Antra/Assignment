using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice.Entities
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set;}
        public int CourseId { get; set; }

        public Student StudentInCourse { get; set; }
        public Course CourseInRegister { get; set; }

    }
}
