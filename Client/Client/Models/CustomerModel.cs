using System.Collections.Generic;


namespace Client.Models
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


