using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithm.sorts
{
    public class SelectionSort
    {

        public void Sort(int[] a)
        {
            var length = a.Length;
            var min = a[0];
            var minIndex = 0;
            for (int i = 0; i < length - 1;  i++,min = a[i], minIndex = i)
            {

                for (int j = i; j <= length - 1; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndex = j;
                    }
                }
                var temp = a[i];
                a[i] = min;

                a[minIndex] = temp;
            }


        }



    }
}