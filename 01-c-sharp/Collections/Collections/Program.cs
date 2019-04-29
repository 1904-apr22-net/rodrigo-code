using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var num2 = 123;
            //Random r2 = 456;
            //Arrays();
            //List();
            //OtherCollections();
        }


        static void Arrays()
        {
            int[] myNums = new int[5];
            for(int i=0; i < myNums.Length; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            // jagged arrays
            int[][] twoD = new int[3][];
            twoD[0] = new int[4];
            twoD[1] = new[] { 1, 6 };
            twoD[2] = new int[4];
            //twoD[2]
            //access the first row and the second column
           // var x = twoD[0][1];
            Console.WriteLine(twoD[2][3]);

            //Multidemsional array 
            int[,] twoDMulti = new int[4, 5]; // 4 by 5
            var y = twoDMulti[0, 1];





            string s = "abra";
            Console.WriteLine(s);
            s= s.Replace("a", string.Empty);
            Console.WriteLine(s);

        }

        static void List()
        {
            ArrayList numList = new ArrayList();
            numList.Add("Hello");
            numList.Add(5);
            numList.Add(8);
            numList.Remove(8);
            //int num = numList[1]; // Does not work because Arraylist returns object type
            var num = (string) numList[0]; // Promising compiler that this is an integer, would cause problems if you're wrong.
            var num2 = numList[1];
            Console.WriteLine(num+", "+num2);
            // implicit and explicit casting
            double d = 4.2;
            int n = (int)d;// downcasting explicit

            int i = 4;
            double x = i; // upcasting (implicit)

            object o = new Random(); // implicit casting (upcasting)
            Random r = (Random)o; // downcasting is explicit, need to tell compiler (random)

            var genericIntList = new List<int>();
            genericIntList.Add(3);
            var value = genericIntList[0];
            //List class can make many List instances, each of which 
            // might have its own type it requires.
            var twoDStringList = new List<List<string>>();
            //twoDStringList.AddRange({ "1", "3", "5"});


        
        }

        static void OtherCollections()
        {
            // Hashset
            var set = new HashSet<string> { "abc", "ab", "ab" };
            set.Add("221Fd");
            var number = set.Count; // 3 (ab is ignored and added new one
            foreach (var item in set)
            {
                //no guarantees about what order they will come out in.
                Console.WriteLine(item);
            }
            Console.WriteLine(number);
            //"Map" or "Dictionary" will store some value for each key.

            //in the same way that in a liat, each index from 0 to the total
            // has some value

            // in the dictionary, each key that you insert will have one value at that spot
            // both hashset and dictionary are implemented with hashtables

            //this means that searching through them for one thing is cheap and fast.

            var numberOfTimesSeenWord = new Dictionary<string, int>();
            numberOfTimesSeenWord["food"] = 1;
            numberOfTimesSeenWord["pc"] = 3;
        } 
    }
}
