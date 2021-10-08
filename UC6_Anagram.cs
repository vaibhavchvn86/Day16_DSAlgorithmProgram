using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_AlgoAssignment
{
    class UC6_Anagram
    {
        public static void Anagram()
        {
            Console.WriteLine(" Enter 1st word");
            string w1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(w1);
            Console.WriteLine(" Enter 2nd word");
            string w2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(w2);

                char[] a = w1.ToLower().ToCharArray();
                char[] b = w2.ToLower().ToCharArray();
                Array.Sort(a);
                Array.Sort(b);
            string x = new string (a);
            string y = new string (b);

                if(x==y)
            {
                Console.WriteLine(w1 + " " + w2 + " are Anagram");
            }
            else
            {
                Console.WriteLine(w1 + " " + w2 + " are not Anagram");
            }
        }
    }
}
