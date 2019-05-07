using StoreDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StoreDataAccess
{
    public class StoreRepository
    {
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


        private readonly ProjectDBContext _dbContext;

        //private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public StoreRepository(ProjectDBContext dbContext) =>
           _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

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

    }
}
