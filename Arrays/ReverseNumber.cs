using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class  ReverseNumber
    {
        public static void Reverse(int num)
        { 
        int rem= 0, rev = 0;
        while (num != 0)
           {
            rem = num % 10;
            rev = (rev * 10) + rem;
            num = num / 10;
           }
            Console.WriteLine("reverse number is: " + rev);
            Console.ReadLine();

        }

    }
}
