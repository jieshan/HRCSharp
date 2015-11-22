using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndValidString
{
    class SherlockAndValidString
    {
        static void Main(String[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(10000)));
            string input = Console.ReadLine();
            int[] check = new int[123];
            for (int i = 0; i < input.Length; i++)
            {
                check[(int)input[i]]++;
            }
            int max = 0;
            int min = input.Length;
            int maxCount = 0;
            int minCount = 0;
            int numChars = 0;
            for (int i = 97; i < check.Length; i++)
            {
                if (check[i] > 0)
                {
                    if (check[i] < min)
                    {
                        min = check[i];
                        minCount = 1;
                    }
                    else if (check[i] == min)
                    {
                        minCount++;
                    }
                    if (check[i] > max)
                    {
                        max = check[i];
                        maxCount = 1;
                    }
                    else if (check[i] == max)
                    {
                        maxCount++;
                    }
                    numChars++;
                }
            }
            if (max == 0 || min == max)
            {
                Console.WriteLine("YES");
            }
            else if (maxCount + minCount != numChars)
            {
                Console.WriteLine("NO");
            }
            else if (Math.Min(maxCount, minCount) > 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
