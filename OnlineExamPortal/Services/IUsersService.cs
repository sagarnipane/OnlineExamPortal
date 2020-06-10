using Microsoft.Azure.Cosmos;
using OnlineExamPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Services
{
    public interface IUsersService
    {
        Task AddUserAsync(Users user);
        Task<IEnumerable<Users>> GetUsersAsync(string query);
    }
}
