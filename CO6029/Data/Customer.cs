using System.Collections.Generic;

namespace CO6029.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public List<Address> Address { get; set; }



    }
}
