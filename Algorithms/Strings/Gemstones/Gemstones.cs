using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstones
{
    class Gemstones
    {
        static void Main(String[] args)
        {
            int numGems = int.Parse(Console.ReadLine());
            int[] total = new int[123];
            for (int i = 0; i < numGems; i++)
            {
                int[] current = new int[123];
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    current[(int)input[j]]++;
                }
                for (int j = 97; j < total.Length; j++)
                {
                    if (current[j] > 0)
                    {
                        total[j]++;
                    }
                }
            }
            int count = 0;
            for (int j = 97; j < total.Length; j++)
            {
                if (total[j] == numGems)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
