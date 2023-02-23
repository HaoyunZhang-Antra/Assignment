using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice.Entities
{
    public class Student : Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override string Address { get; set; }
        public List<int> CoursesTaken { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
