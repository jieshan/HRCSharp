using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMedian
{
    class FindTheMedian
    {
        static int[] sorted;
        static int[] quickSort(int[] ar, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(ar, lo, hi);
                quickSort(ar, lo, p - 1);
                quickSort(ar, p + 1, hi);
            }
            return ar;
        }

        static int partition(int[] ar, int lo, int hi)
        {
            int pivot = ar[hi];
            int i = lo;
            int temp;
            for (int j = lo; j <= hi - 1; j++)
            {
                if (ar[j] <= pivot)
                {
                    temp = ar[i];
                    ar[i] = ar[j];
                    ar[j] = temp;
                    i = i + 1;
                }
            }
            temp = ar[i];
            ar[i] = ar[hi];
            ar[hi] = temp;
            return i;
        }

        /* Tail starts here */
        static void Main(String[] args)
        {

            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            sorted = quickSort(_ar, 0, _ar.Length - 1);
            Console.WriteLine(sorted[_ar_size / 2]);
        }
    }
}
