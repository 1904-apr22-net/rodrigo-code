using System;
using Xunit;
using StoreApplication;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace StoreApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCustomer()
        {
            Customer Rod = new Customer();
            Location L1 = new Location();
            string FName = "Rodrigo";
            string LName = "Salomon";
            L1.Name = "Dallas";
            Rod.CreateCustomer(FName, LName);
            Rod.Output();
            





        }
    }
}
