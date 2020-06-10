using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineExamPortal.Models;
using OnlineExamPortal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Services
{
    public class EmployeesService : IRepository<Employees>
    {
        private readonly OnlineExamPortalDbContext context;
        public EmployeesService(OnlineExamPortalDbContext dbContext)
        {
            context = dbContext;
        }
        public Employees Add(Employees model)
        {
            context.Employees.AddAsync(model);
            context.SaveChanges();
            return model;
        }

        public void Delete(Employees model)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(object Id)
        {
            var emp = context.Employees.Where(model => model.Id == Convert.ToInt32(Id)).First();
            context.Employees.Remove(emp);
            context.SaveChanges();
        }

        public IEnumerable<Employees> GetAll()
        {
            return  context.Employees.ToList();
        }

        public Employees GetById(object Id)
        {
            return context.Employees.Where(model => model.Id == Convert.ToInt32(Id)).First();
        }

        public void Modify(Employees model)
        {
            context.Update(model);
            context.SaveChanges();
        }
    }
}
