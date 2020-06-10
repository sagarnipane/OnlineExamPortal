using Microsoft.Azure.Cosmos;
using OnlineExamPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Container = Microsoft.Azure.Cosmos.Container;
namespace OnlineExamPortal.Services
{
    public class UsersService : IUsersService
    {
        private Container _container;
        public UsersService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }
        public async Task AddUserAsync(Users user)
        {
            await this._container.CreateItemAsync<Users>(user, new PartitionKey(user.Id));
        }

        public async Task<IEnumerable<Users>> GetUsersAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Users>(new QueryDefinition(queryString));
            List<Users> result = new List<Users>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                result.AddRange(response.ToList());
            }
            return result;

        }

       
    }
}
