using System;
using System.Collections.Generic;
using System.Linq;

namespace CO6029.Modles
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CreatedDate { get; set; }

        public string PaymentPaidDate { get; set; }

        public string DispatchedDate { get; set; }

        public decimal OrderTotal => Math.Round(Basket.Aggregate(0m, (t, x) => t += x.Price * x.Quantity), 2);

        public IList<ProductModel> Basket { get; set; } = new List<ProductModel>();
    }
}

