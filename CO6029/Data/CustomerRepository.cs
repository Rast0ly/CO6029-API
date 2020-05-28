using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Data
{
    public class CustomerRepository : ICustomerRepository


    {
        private readonly Database _database;

        public CustomerRepository(Database database)
        {
            _database = database;
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _database.Customers
                .Include(x => x.Address)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            return await _database.Customers
                 .Include(x => x.Address)
                 .ToListAsync();
        }
    }
}
