using StoreDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace StoreDataAccess
{
    public class StoreRepository
    {
        private readonly ProjectDBContext _dbContext;
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public StoreRepository(ProjectDBContext dbContext) =>
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        /*
       static void Main(string[] args)
       {

           using (ProjectDBContext dbContext = CreateDBContext())
           {
               PrintLocation(dbContext);

               //AddAMovie(dbContext);

               //PrintMovies(dbContext);

               //UpdateAMovie(dbContext);

               //PrintMovies(dbContext);

               //DeleteAMovie(dbContext);

               //PrintMovies(dbContext);
           }


       }
       */

        //private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();


        /*
        public static void PrintLocation()
        {
            // string toReturn = null;
            //foreach (Location location in dbContext.Location.Include(l => l.Customers))
            foreach (Location location in _dbContext.Location)
            {
                Console.WriteLine($" {location.Name}: {location.State} ");
                //toReturn = toReturn + temp;
            }
            Console.WriteLine();


        }
        */
        public StoreClasses.Location GetLocationById(int id) =>
            Mapper.Map(_dbContext.Location.Find(id));


        public IEnumerable<StoreClasses.Location> GetLocation(string search = null)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Location> items =
                _dbContext.Location
                .Include(l => l.Customers).AsNoTracking();
            if (search != null)
            {
                items = items.Where(l => l.Name.Contains(search));
            }
            return Mapper.Map(items);
        }

        public int AddOrder(StoreClasses.Customer customer, int productOrdered, int nextOrderId)
        {
            StoreClasses.Order order = new StoreClasses.Order();
            order.Id = nextOrderId;
            order.OrderTime = DateTime.Now;
            order.Customer = customer;
            order.Location = customer.CustLocation;
            _logger.Info($"Adding Order");

            Orders entity = Mapper.Map(order);
            //entity.Id = nextOrderId;
            _dbContext.Add(entity); 
            if(productOrdered == 1 || productOrdered == 2 || productOrdered == 3)
            {
                OrderItem entity1 = new OrderItem();
                entity1.Id = nextOrderId;
                entity1.OrderId = nextOrderId;
                entity1.ProductId = productOrdered;
                _dbContext.Add(entity);
                return 1;
            }
            else if(productOrdered ==4)
            {
                OrderItem entity1 = new OrderItem();
                entity1.Id = nextOrderId;
                entity1.OrderId = nextOrderId;
                entity1.ProductId = (productOrdered-3);
                _dbContext.Add(entity1);
                OrderItem entity2 = new OrderItem();
                entity2.Id = nextOrderId+1;
                entity2.OrderId = nextOrderId;
                entity2.ProductId = (productOrdered - 2);
                _dbContext.Add(entity2);
                OrderItem entity3 = new OrderItem();
                entity3.Id = nextOrderId + 2;
                entity3.OrderId = nextOrderId;
                entity3.ProductId = (productOrdered - 1);
                _dbContext.Add(entity3);
                return 3; 
            }
            return 0;
            
        }

        public void AddLocation(StoreClasses.Location loc)
        {
            Location entity1 = Mapper.Map(loc);
            _dbContext.Add(entity1);
            Console.WriteLine("Should add loc");
        }

        public void DisplayOrder(int orderId)
        {
            var orders = GetOrders().ToList();
            for (var i = 0; i < orders.Count; i++)
            {
                var order = orders[i];
                if (order.Id == orderId)
                {
                    Console.WriteLine("Order customer: " + order.Customer.FirstName + " " + order.Customer.LastName);
                   // List< products = order.OrderItem();
                }
            }
        }

        public IEnumerable<StoreClasses.Order> GetOrders()
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Orders> orders2 =
                _dbContext.Orders
                .Include(o => o.OrderItem).ThenInclude(p => p.Product);
               _dbContext.Orders
               .Include(c => c.Customer);
            return Mapper.Map(orders2);
        }

    }
}
