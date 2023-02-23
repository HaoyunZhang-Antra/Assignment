using PersonPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice.Contracts
{
    public interface IInstructorService : IRepository<Instructor>
    {
        public void changeSalary(int id, decimal Salary);
    }
}
