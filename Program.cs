using System;
using System.IO;

namespace Day16_AlgoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region UC1
            //string S = "ABC";
            //int n = S.Length;
            //UC1.Permute(S,0,n-1);
            //#endregion

            //#region UC2
            //UC2_BinarySerachWord.BSTWord();
            //#endregion

            //UC3_InsertionSort.Isort();

            //UC4_Bubblesort.Bubble();

            //#region UC5
            //int[] a = new int[] { 15, 3, 1, 10, 9, 13 };
            //UC5_MergeSort msort = new UC5_MergeSort();
            //Console.WriteLine("Unsorted Array");
            //msort.Display(a);
            //msort.Sort(a, 0, a.Length - 1);
            //Console.WriteLine("\n Sorted Array");
            //msort.Display(a);
            //#endregion

            //UC6_Anagram.Anagram();

            //UC7.Prime();
            UC8_PrimeAnagram.Prime_Anagram();

            //UC10_GuessNum.GuessNumber();
            
            //UC12_RegexReplace.Regex1();
        }
    }
}
