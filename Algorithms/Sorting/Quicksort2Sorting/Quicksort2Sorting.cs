using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort2Sorting
{
    class Quicksort2Sorting
    {
        static int[] quickSort(int[] ar)
        {
            if (ar.Length <= 1)
            {
                return ar;
            }
            int pivot = ar[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] <= pivot)
                {
                    left.Add(ar[i]);
                }
                else
                {
                    right.Add(ar[i]);
                }
            }
            int[] leftSorted = quickSort(left.ToArray());
            int[] rightSorted = quickSort(right.ToArray());
            int[] sorted = new int[ar.Length];
            leftSorted.CopyTo(sorted, 0);
            sorted[leftSorted.Length] = pivot;
            rightSorted.CopyTo(sorted, leftSorted.Length + 1);
            Console.WriteLine(String.Join(" ", sorted));
            return sorted;
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

            quickSort(_ar);
        }
    }
}
