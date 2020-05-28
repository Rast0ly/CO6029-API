
using CO6029.Data;
using System.Collections.Generic;
using System.Linq;

namespace CO6029.Modles

{
    public static class CustomerEntityModelMapping
    {
        public static IList<CustomerModel> ToModel(this IList<Customer> customers)
        {
            return customers.Select(x => ToModel(x)).ToList();
        }

        public static CustomerModel ToModel(this Customer x)
        {
            return new CustomerModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                EmailAddress = x.EmailAddress,
                Address = x.Address.Select(y => new AddressModel
                {
                    Id = y.Id,
                    Street = y.Street,
                    CityTown = y.CityTown,
                    County = y.County,
                    PostalCode = y.PostalCode,
                    Country = y.Country
                }).ToList()
            };
        }
    }
}