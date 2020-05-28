using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Data
{
    public class OrderRepository : IOrderRepository


    {
        private readonly Database _database;

        public OrderRepository(Database database)
        {
            _database = database;
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _database.Orders
                .Include(x => x.Customer)
                .Include(x => x.OrderLines)
                .ThenInclude(x => x.Product)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<Order>> GetAllOrdersAsync()
        {
            return await _database.Orders
                 .Include(x => x.Customer)
                 .Include(x => x.OrderLines)
                 .ThenInclude(x => x.Product)
                 .ToListAsync();
        }
    }
}
