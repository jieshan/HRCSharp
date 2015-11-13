using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortPart1
{
    class InsertionSortPart1
    {
        static void insertionSort(int[] ar)
        {
            int len = ar.Length;
            if(len == 1)
            {
                Console.WriteLine(ar[0]);
                return;
            }
            int e = ar[ar.Length-1];
            for (int i = ar.Length - 2; i >= 0; i--) 
            {
                if (e < ar[i])
                {
                    ar[i + 1] = ar[i];
                    Console.WriteLine(String.Join(" ", ar));
                }
                else 
                {
                    ar[i + 1] = e;
                    Console.WriteLine(String.Join(" ", ar));
                    return;
                }
            }
            ar[0] = e;
            Console.WriteLine(String.Join(" ", ar));
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

            insertionSort(_ar);
        }
    }
}
