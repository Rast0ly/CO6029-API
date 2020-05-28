using System;

namespace Client.Models
{



    public class ProductModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal SubTotal => Math.Round(Price * Quantity, 2);
    }


}

