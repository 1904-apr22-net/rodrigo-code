using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreClasses;
using StoreDataAccess.Entities;
//using StoreClasses;

namespace StoreDataAccess
{
    class Mapper
    {
        public static StoreClasses.Location Map(Entities.Location location) => new StoreClasses.Location
        {
            Id = location.Id,
            Name = location.Name,
            Street = location.Street,
            City = location.City,
            State= location.State,
            CustomersAtLocation = Map(location.Customers).ToList()
        };

        
        public static Entities.Location Map(StoreClasses.Location location) => new Entities.Location
        {
            Id = location.Id,
            Name = location.Name,
            Street = location.Street,
            City = location.City,
            State = location.State,
        };
        
        public static StoreClasses.Customer Map(Entities.Customers customer) => new StoreClasses.Customer

        {
            Id = customer.Id,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            PhoneNumber = customer.PhoneNumber,
            //CustLocation = Map(customer.Location),
            //CustOrder = Map(customer.Orders)
        };
        
        public static Entities.Customers Map(StoreClasses.Customer customer) => new Entities.Customers
        {
            Id = customer.Id,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            PhoneNumber = customer.PhoneNumber,
            //Review = Map(restaurant.Reviews).ToList()
        };


        public static StoreClasses.Order Map(Entities.Orders order) => new StoreClasses.Order
        {
            Id = order.Id,
            OrderTime = order.Time,
            //CustomerId = order.CustomerId,
            //LocationId = order.LocationId,
            Customer = Map(order.Customer),
            Location = Map(order.Customer.Location),
            //OrderItem = 
            //int x=0;
          // product = order.OrderItem;
            //ProductsOrdered = (orderItem => orderItem.Product.Name)

        };
        public static Entities.Orders Map(StoreClasses.Order order) => new Entities.Orders
        {
            Id = order.Id,
            Time = order.OrderTime,
            CustomerId = order.Customer.Id,
            LocationId = order.Location.Id,
            //Customer = Map(order.Customer),
            //Location = Map(order.Customer.CustLocation),

        };

        public static IEnumerable<StoreClasses.Location> Map(IEnumerable<Entities.Location> location) =>
             location.Select(Map);

        public static IEnumerable<Entities.Location> Map(IEnumerable<StoreClasses.Location> location) =>
            location.Select(Map);
        

        public static IEnumerable<StoreClasses.Customer> Map(IEnumerable<Entities.Customers> customers) =>
            customers.Select(Map);

        /*
        public static IEnumerable<Entities.Customers> Map(IEnumerable<StoreClasses.Customer> customers) =>
            customers.Select(Map);
            */
        public static IEnumerable<StoreClasses.Order> Map(IEnumerable<Entities.Orders> orders) =>
        orders.Select(Map);

        public static IEnumerable<Entities.Orders> Map(IEnumerable<StoreClasses.Order> order) =>
            order.Select(Map);
    }
}
