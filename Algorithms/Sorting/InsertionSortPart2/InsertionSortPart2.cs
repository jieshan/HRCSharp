using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortPart2
{
    class InsertionSortPart2
    {
        static void insertionSort(int[] ar)
        {
            int len = ar.Length;
            if (len == 1)
            {
                Console.WriteLine(ar[0]);
                return;
            }
            for (int i = 1; i < len; i++ ) 
            {
                int e = ar[i];
                bool inserted = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (e < ar[j])
                    {
                        ar[j + 1] = ar[j];
                    }
                    else
                    {
                        ar[j + 1] = e;
                        inserted = true;
                        Console.WriteLine(String.Join(" ", ar));
                        break;
                    }
                }
                if (!inserted)
                {
                    ar[0] = e;
                    Console.WriteLine(String.Join(" ", ar));
                }
            }
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

            insertionSort(_ar);
        }
    }
}
