using System.Collections.Generic;


namespace CO6029.Modles
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public List<AddressModel> Address { get; set; } = new List<AddressModel>();



    }
}


