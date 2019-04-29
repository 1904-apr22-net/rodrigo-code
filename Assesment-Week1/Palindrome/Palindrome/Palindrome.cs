using System;
using System.Text.RegularExpressions;
//using TestPalindrome.csproj;

namespace Palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string toCheck)
        {
            RemoveSpaces(toCheck);
            RemoveCapitals(toCheck);





            return false;
        }

        private string RemoveCapitals(string toCheck)
        {
            string s = toCheck;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    Char.ToUpper(s[i]);
                }
            }
            toCheck = s;
            return toCheck;
        }

        private string RemoveSpaces(string toCheck)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            toCheck = rgx.Replace(toCheck, "");
            return toCheck;
        }


    }
}
