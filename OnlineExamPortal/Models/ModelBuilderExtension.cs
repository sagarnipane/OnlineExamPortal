using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasData(

                new Employees
                { 
                    Id = 1,
                    Name = "Sagar",
                    Email = "spnipane@gmail.com",
                    Department = Dept.IT
                },
                new Employees
                {
                    Id=2,
                    Name="Shubham Nimje",
                    Email="shubham@gmail.com",
                    Department= Dept.Account
                }
            );
        }
    }
}
