using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLoveLetterMystery
{
    class TheLoveLetterMystery
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string input = Console.ReadLine();
                int start = 0;
                int end = input.Length - 1;
                int count = 0;
                while (end > start)
                {
                    count += Math.Abs((int) input[start] - (int) input[end]);
                    start++;
                    end--;
                }
                Console.WriteLine(count);
            }
        }
    }
}
