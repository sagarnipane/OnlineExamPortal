using OnlineExamPortal.Models;
using OnlineExamPortal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Services
{
    public class ExamService : IRepository<Exam>
    {
        //private readonly 
        public ExamService()
        {

        }
        public Exam Add(Exam model)
        {
            if(model != null)
            {

            }
            return null;
        }

        public void Delete(Exam model)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exam> GetAll()
        {
            throw new NotImplementedException();
        }

        public Exam GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public void Modify(Exam model)
        {
            throw new NotImplementedException();
        }
    }
}
