using System.Collections;
using System.Collections.Generic;

namespace CO6029.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }
}

