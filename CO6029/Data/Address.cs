namespace CO6029.Data
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string CityTown { get; set; }

        public string County { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }





    }
}
