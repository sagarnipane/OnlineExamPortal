using OnlineExamPortal.Models;
using OnlineExamPortal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.SqlRepository
{
    public class SQLUsersRepository : IUsersRepository
    {
        private readonly OnlineExamPortalDbContext Context;
        public SQLUsersRepository(OnlineExamPortalDbContext Context)
        {
            this.Context = Context;
        }

        public Users Add(Users user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            return user;
        }

        public Users Delete(int Id)
        {
            Users user = Context.Users.Find(Id);
            if (user != null)
            {
                Context.Users.Remove(user);
                Context.SaveChanges();
            }
            return user;
        }

        public Users GetUser(int Id)
        {
            return Context.Users.Find(Id);

        }

        public IEnumerable<Users> GetUser()
        {
            return Context.Users;
        }

        public IEnumerable<Users> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Users Update(Users userChanges)
        {
            var product = Context.Users.Attach(userChanges);
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return userChanges;
        }
    }
}


new SelectListItem(Enum.GetValues(typeof(Dept)))