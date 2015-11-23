using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningTimeOfQuicksort
{
    class RunningTimeOfQuicksort
    {
        static int insertionShifts = 0;
        static int quickShifts = 0;

        static void insertionSort(int[] ar)
        {
            insertionShifts = 0;
            int len = ar.Length;
            if (len == 1)
            {
                Console.WriteLine(insertionShifts);
                return;
            }
            for (int i = 1; i < len; i++)
            {
                int e = ar[i];
                bool inserted = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (e < ar[j])
                    {
                        ar[j + 1] = ar[j];
                        insertionShifts++;
                    }
                    else
                    {
                        ar[j + 1] = e;
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    ar[0] = e;
                }
            }
        }

        static void quickSort(int[] ar, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(ar, lo, hi);
                quickSort(ar, lo, p - 1);
                quickSort(ar, p + 1, hi);
            }
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
                    quickShifts++;
                }
            }
            temp = ar[i];
            ar[i] = ar[hi];
            ar[hi] = temp;
            quickShifts++;
            return i;
        }

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

            int[] _ar2 = (int[])_ar.Clone();

            insertionSort(_ar);
            quickSort(_ar2, 0, _ar2.Length - 1);
            Console.WriteLine(insertionShifts - quickShifts);
        }
    }
}
