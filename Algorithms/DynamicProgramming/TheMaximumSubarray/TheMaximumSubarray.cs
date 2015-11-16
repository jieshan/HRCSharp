using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMaximumSubarray
{
    class TheMaximumSubarray
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                int len = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(' ');
                int[] array = new int[len];
                for (int j = 0; j < len; j++)
                {
                    array[j] = int.Parse(input[j]);
                }
                int sum1 = 0;
                int current = 0;
                for (int j = 0; j < len; j++)
                {
                    current = Math.Max(0, current + array[j]); 
                    if (current > sum1)
                    {
                        sum1 = current;
                    }
                }
                if (sum1 == 0)
                {
                    sum1 = Math.Min(sum1, array.Max());
                }
                int sum2 = 0;
                for (int j = 0; j < len; j++)
                {
                    if (array[j] > 0)
                    {
                        sum2 += array[j];
                    }
                }
                if (sum2 == 0)
                {
                    sum2 = Math.Min(sum2, array.Max());
                }
                Console.WriteLine(String.Format("{0} {1}", sum1, sum2));
            }
        }
    }
}
