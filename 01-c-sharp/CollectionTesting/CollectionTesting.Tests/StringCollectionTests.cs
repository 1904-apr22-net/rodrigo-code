using System;
using Xunit;

namespace CollectionTesting.Tests
{
    public class StringCollectionTests
    {
        [Fact]
        public void CtorZeroThrowsNoExceptions()
        {
            // three steps to a good unit test
            //1. Arrange
            //2. act (the behavior you are testing)
            var c = new StringCollection();
            //3. Assert(verify the behavior was correct.)
        }
    }
}
