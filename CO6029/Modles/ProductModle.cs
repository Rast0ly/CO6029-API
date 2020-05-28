using System;

namespace CO6029.Modles
{



    public class ProductModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal SubTotal => Math.Round(Price * Quantity, 2);
    }


}

