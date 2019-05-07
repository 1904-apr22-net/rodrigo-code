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
        };

        public static Entities.Location Map(StoreClasses.Location location) => new Entities.Location
        {
            Id = location.Id,
            Name = location.Name,
            Street = location.Street,
            City = location.City,
            State = location.State,
        };

        public static IEnumerable<StoreClasses.Location> Map(IEnumerable<Entities.Location> location) =>
             location.Select(Map);

        public static IEnumerable<Entities.Location> Map(IEnumerable<StoreClasses.Location> location) =>
            location.Select(Map);
    }
}
