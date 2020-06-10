using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Models
{
    public class OnlineExamPortalDbContext :IdentityDbContext
    {
        public OnlineExamPortalDbContext(DbContextOptions<OnlineExamPortalDbContext> options) : base(options)
        {

        }
        public new DbSet<Users> Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Domain> Domain { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
    }
}
