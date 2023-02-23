using PersonPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice.Contracts
{
    public interface IStudentService : IRepository<Student>
    {
        public void addressChange(int id, string address);
    }
}
