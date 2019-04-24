using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public void multipleof3(int n)
        {
            for (int i = 3; i <= n;)
            {
                Console.Write(i + ", ");
                i = i + 3;
            }

        }
        public void multipleof3reverse(int n)
        {
            bool flag = true;
            while (flag)
            {
                int remainder = n % 3;
                if (remainder == 0)
                {
                    flag = false;
                    break;
                }
                n--;
            }
            for (int i = n; n > 0;)
            {
                Console.Write(n + ", ");
                n -= 3;
            }

        }
    }
}
