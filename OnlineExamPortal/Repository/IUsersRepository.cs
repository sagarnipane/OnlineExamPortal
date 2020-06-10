using OnlineExamPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Repository
{
    interface IUsersRepository
    {
        Users GetUser(int Id);
        IEnumerable<Users> GetUsers();
        Users Add(Users user);
        Users Update(Users userChanges);
        Users Delete(int Id);
    }
}
