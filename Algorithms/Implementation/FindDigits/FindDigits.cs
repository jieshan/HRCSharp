using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class FindDigits
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string input = Console.ReadLine();
                int val = int.Parse(input);
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    int digit = int.Parse(input[j].ToString());
                    if (digit != 0 && val % digit == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
