using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity model) ;

        IEnumerable<TEntity> GetAll();

        TEntity GetById(object Id);

        void Modify(TEntity model);

        void Delete(TEntity model);

        void DeleteById(object Id);
    } 
}
