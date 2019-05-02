using System;
using System.Text.RegularExpressions;

namespace Palindromes.Library
{
    public class Palindrome
    {
        string CheckPalindrome = null;
        //protected List<T> List { set; get; } = new List<T>();

        public Palindrome()
        {
            //CheckPalindrome = this.CheckPalindrome;
            // if we code no constructor on a class,
            // it has a default constructor automatically.
            // it is public, with no parameters, and has no contents.

            // as soon as we define any constructor, the default one goes away.
        }
        public bool IsPalindrome(string toCheck)
        {
            RemoveSpaces(toCheck);
            RemoveCapitals(toCheck);

            return false;
        }

        public string RemoveCapitals(string toCheck)
        {
            string s = toCheck;
            char[] s2 = s.ToCharArray();
            for (int i = 0; i < s2.Length; i++)
            {
                if (Char.IsLetter(s2[i]))
                {
                    char c = Char.ToLower(s2[i]);
                    s2[i] = c;
                }
            }
            toCheck = s2.ToString();
            Console.WriteLine(s2 + toCheck);
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
