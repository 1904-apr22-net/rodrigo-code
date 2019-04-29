using System;
using System.Text.RegularExpressions;
//using TestPalindrome;

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

        public string RemoveCapitals(string toCheck)
        {
            string s = toCheck;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    Char.ToLower(s[i]);
                }
            }
            toCheck = s;
            return toCheck;
        }

        public string RemoveSpaces(string toCheck)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            toCheck = rgx.Replace(toCheck, "");
            return toCheck;
        }


    }
}
