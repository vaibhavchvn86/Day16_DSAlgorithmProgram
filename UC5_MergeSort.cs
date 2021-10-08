using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_AlgoAssignment
{
    class UC5_MergeSort
    {
        public static void Merge(int[] a, int lo, int m, int hi)
        {
            int n1 = m - lo + 1;
            int n2 = hi - m;

            int[] LO = new int[n1];
            int[] HI = new int[n2];

            int i, j;
            for (i = 0; i < n1; i++)
                LO[i] = a[lo + i];
            for (j = 0; j < n2; j++)
                HI[j] = a[m + 1 + j];
            i = 0; j = 0;
            int k = lo;
            while (i < n1 && j < n2)
            {
                if (LO[i] <= HI[j])
                {
                    a[k] = LO[i];
                    i++;
                }
                else
                {
                    a[k] = HI[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                a[k] = LO[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                a[k] = HI[j];
                j++;
                k++;
            }
        }
        public void Sort(int[]a,int lo, int hi)
        {
            if(lo<hi)
            {
                int m = lo + (hi - lo) / 2;
                Sort(a,lo, m);
                Sort(a, m + 1, hi);
                Merge(a, lo, m, hi);

            }
        }
        public void Display(int[]a)
        {
            int n = a.Length;
            for(int i=0; i<n;i++)
            {
                Console.WriteLine(a[i]+" ");
            }
        }
    }
}
