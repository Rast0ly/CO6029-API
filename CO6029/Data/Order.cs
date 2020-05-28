using System.Collections.Generic;

namespace CO6029.Data
{

    public class Order
    {
        public int Id { get; set; }

        public string CreatedDate { get; set; }

        public string PaymentPaidDate { get; set; }


        public string DispatchedDate { get; set; }
        public Customer Customer { get; set; }

        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}

