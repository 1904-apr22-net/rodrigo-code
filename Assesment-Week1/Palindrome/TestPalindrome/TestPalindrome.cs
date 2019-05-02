using System;
using Xunit;
using Palindromes.Library;

namespace TestPalindromes.Test
{
    public class TestPalindrome
    {
        [Fact]
        public void TestRemoveSpaces()
        {
            Palindrome a = new Palindrome();
            //a.checkPalindrome = "Hello my friend.";
           String str = "Hello$%#$#@@friend . . hoLa.";
            String str2 = a.RemoveSpaces(str);
            Assert.Equal("HellofriendhoLa", str2);

        }
        [Fact]
        public void TestRemoveCapitals()
        {
            Palindrome b = new Palindrome();
            String str = "HeYFrIeNd";
            String str2 = b.RemoveCapitals(str);
            Assert.Equal("heyfriend", str2);

        }
        [Fact]
        public void TestIsPalindrome()
        {
            Palindrome c = new Palindrome();
            String str = "Hello my friend.";
            Assert.False(c.IsPalindrome(str));
            Assert.False(c.IsPalindrome("Race CAR!"));
            

        }
    }
}
