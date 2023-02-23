using PersonPractice.Contracts;
using PersonPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice
{
    public class StudentRepository : IStudentService

    {
        public StudentRepository() 
        {
            
        }

        public void addressChange(int id, string address)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Student obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
