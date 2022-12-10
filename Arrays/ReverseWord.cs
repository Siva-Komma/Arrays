using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ReverseWord
    {
        public static void ReverseW(String name)
        {
            String rev = " ";
            char[] chars = name.ToCharArray();
            Console.WriteLine("Display the char");
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + " ");
            }
            for (int i = 0; i < chars.Length; i++)
            {
                rev = chars[i] + rev;
            }
            Console.WriteLine("\n" + rev);
            Console.WriteLine("reverse word is: " + rev);
            if (name==rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    } 
}
