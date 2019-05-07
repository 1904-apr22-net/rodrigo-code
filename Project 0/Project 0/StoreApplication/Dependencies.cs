using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StoreApplication;
using System.Xml.Serialization;
using StoreDataAccess.Entities;
using System.Data.SqlClient;
using StoreDataAccess;

namespace StoreApplication
{
    public static class Dependencies
    {
        

        public static StoreRepository CreateStoreRepository()
        {
            var SecretConfiguration = new SqlConnectionStringBuilder();
            SecretConfiguration.DataSource = "Server=tcp:salomon1904sql.database.windows.net";
            SecretConfiguration.UserID = "rodsalomon10";
            SecretConfiguration.Password = "Salermo10";
            SecretConfiguration.InitialCatalog = "Initial Catalog=ProjectDB";
            SecretConfiguration.PersistSecurityInfo = false;
            SecretConfiguration.ConnectTimeout = 30;
            SecretConfiguration.MultipleActiveResultSets = false;
            SecretConfiguration.TrustServerCertificate = false;
            //"Server=tcp:salomon1904sql.database.windows.net,1433;Initial Catalog=ProjectDB;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

            var optionsBuilder = new DbContextOptionsBuilder<ProjectDBContext>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);

            var dbContext = new ProjectDBContext(optionsBuilder.Options);

            return new StoreRepository(dbContext);


            //var dbContext = new RestaurantReviewsDbContext(optionsBuilder.Options);

            //return new RestaurantRepository(dbContext);
        }
    }


}
