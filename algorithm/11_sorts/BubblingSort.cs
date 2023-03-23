using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithm.sorts
{
    public class BubblingSort
    {
        public (int CompareTimes, int ExchangeTimes) Sort(int[] a)
        {
            var length = a.Length;
            var compareTimes = 0;
            var exchangeTimes = 0;
            if (length > 1)
            {

                for (int i = 0; i < length; i++)
                {
                    var flag = false;

                    for (int j = 0; j < length - i - 1; j++)
                    {

                        compareTimes++;
                        if (a[j] > a[j + 1])
                        {
                            exchangeTimes++;
                            var temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                            flag = true;
                        }

                    }
                    if (!flag)
                        break;
                }

            }

            return (compareTimes, exchangeTimes);
        }

    }
}