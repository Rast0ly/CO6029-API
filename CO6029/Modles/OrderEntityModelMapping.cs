
using CO6029.Data;
using CO6029.Modles;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System.Collections.Generic;
using System.Linq;

namespace Api.Models.Orders
{
    public static class OrderEntityModelMapping
    {
        public static IList<OrderModel> ToModel(this IList<Order> orders)
        {
            return orders.Select(x => ToModel(x)).ToList();
        }

        public static OrderModel ToModel(this Order x)
        {
            var model = new OrderModel
            {
                Id = x.Id,
                FirstName = x.Customer.FirstName,
                LastName = x.Customer.LastName,
                CreatedDate = x.CreatedDate,
                PaymentPaidDate = x.PaymentPaidDate,
                DispatchedDate = x.DispatchedDate,
                Basket = x.OrderLines.Select(y => tooModle(y)).ToList()
            };

            return model;
        }

        private static ProductModel tooModle(OrderLine y)
        {
            
            return new ProductModel
            {
                Name = y.Product.Name,
                Price = y.Product.Price,
                Quantity = y.Quantity
            };
        }
    }
}