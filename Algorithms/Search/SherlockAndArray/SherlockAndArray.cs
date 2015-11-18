using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndArray
{
    class SherlockAndArray
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                int len = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(' ');
                long sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    sum += int.Parse(input[j]);
                }
                long left = 0;
                long right = sum;
                bool found = false;
                for (int j = 0; j < input.Length; j++) 
                {
                    int current = int.Parse(input[j]);
                    right -= current;
                    if (left == right)
                    {
                        found = true;
                        break;
                    }
                    else
                    {
                        left += current;
                    }
                }
                if (found)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
