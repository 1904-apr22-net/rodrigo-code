using System;
using Xunit;
using StoreApplication;

namespace StoreApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Customer Rod = new Customer();
            Order first = new Order();
            Location Dallas = new Location();
            Rod.FirstName = ("Rodrigo");
            Rod.CustLocation = Dallas;
            first.Customer = Rod;
            first.Location = first.Customer.CustLocation;
            first.OrderTime = new TimeSpan(11, 59, 59);
            Assert.Equal("Rodrigo", first.Customer.FirstName);



        }
    }
}
