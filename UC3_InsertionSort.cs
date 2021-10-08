using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_AlgoAssignment
{
    class UC3_InsertionSort
    {
        public static void Isort()
        {
            string[] arr = new string[] { "Ant", "Bird", "Cat", "Mouse", "Horse" };
            int n = arr.Length;
            sort(arr,n);
            Display(arr, n);

            static void sort(string[] a,int n)
            {

                //int i, j, temp, flag;
                

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                }
                for (int i = 1; i < n; i++)
                {
                    string temp = a[i];
                    //flag = 0;
                    int j = i - 1;
                    while (j >= 0 && temp.Length < a[j].Length)
                    {

                        a[j + 1] = a[j];
                        j--;
                    }
                    a[j + 1] = temp;
                }
            }
            static void Display(string[] a, int n)
            {
                Console.Write("\n Sorted Array ");
                for (int i = 0; i < n; i++)
                { Console.Write(a[i] + " "); }
            }
        }
    }
}
