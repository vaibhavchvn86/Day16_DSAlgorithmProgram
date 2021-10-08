using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day16_AlgoAssignment
{
    public class UC2_BinarySearchWord
    {
        public static void BSTWord()
        {
            string file = File.ReadAllText(@"C:\Users\vaibh\source\repos\Day16_AlgoAssignment\Day16_AlgoAssignment\UC2_BinarySerachWord\UC2_BSTWord.txt");
            Console.WriteLine("Contenet of file => " + file);
            string[] w = file.Split(",");
            Array.Sort(w);
            Console.WriteLine(" sorted array");
            Display(w);
            Result(file);
            

            static void Result(string file)
            {
                string[] w = file.Split(",");
                string x = "Dog";
                int result = BST(w, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element fount at index " + result);
        }
        }
        static int BST(string[]w,string x)
        {
            int l = 0, r = w.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                int res = x.CompareTo(w[m]);
                if (res == 0)
                    return m;
                else if (res > 0)
                {
                    l = m + 1;
                    return l;
                }
                else
                {
                    r = m - 1;
                    return r;
                }
            }
            return r;
        }
        public static void Display(string[] w)
        {
            foreach(string wc in w)
            {
                Console.WriteLine(wc);
            }
        }
    }
}
