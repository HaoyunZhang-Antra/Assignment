using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; } 

        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }


    }
}
