using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithm.sorts
{
    public class InsertionSort
    {

        public void Sort(int[] a)
        {
            var length = a.Length;
            if (length <= 1) return;
            for (int i = 1; i <= length - 1; i++)
            {
                var value = a[i];
                var j = i - 1;

                for (; j >= 0; j--)
                {
                    if (a[j] > value)
                    {

                        a[j + 1] = a[j];
                    }
                    else
                    {
                        break;

                    }

                }
                a[j + 1] = value;

            }

        }

    }
}