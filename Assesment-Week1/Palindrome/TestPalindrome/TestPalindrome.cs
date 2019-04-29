using System;
using Xunit;
using Palindrome;

namespace TestPalindrome
{
    public class TestPalindrome
    {
        [Fact]
        public void TestRemoveSpaces()
        {
            String str = "Hello my friend.";
            String str2 = RemoveSpaces(str);
            Assert.Equal("Hellomyfriend", str2);

        }
    }
}
