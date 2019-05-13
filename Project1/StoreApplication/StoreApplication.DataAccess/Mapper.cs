using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StoreApplication.DataAccess.Entities;

namespace StoreApplication.DataAccess
{
    public class Mapper
    {
        public static Library.Customer Map(Entities.Customers customer) => new Library.Customer

        {
            Id = customer.Id,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            PhoneNumber = customer.PhoneNumber,
            //CustLocation = Map(customer.Location),
            //CustOrder = Map(customer.Orders)
            CustLocation = Map(customer.Location)
        };

        public static Library.Location Map(Entities.Location location) => new Library.Location
        {
            Id = location.Id,
            Name = location.Name,
            Street = location.Street,
            City = location.City,
            State = location.State,
            //CustomersAtLocation = Map(location.Customers).ToList()
        };

        public static IEnumerable<Library.Customer> Map(IEnumerable<Entities.Customers> customers) =>
            customers.Select(Map);

        public static IEnumerable<Library.Location> Map(IEnumerable<Entities.Location> locations) =>
            locations.Select(Map);


    }
}
