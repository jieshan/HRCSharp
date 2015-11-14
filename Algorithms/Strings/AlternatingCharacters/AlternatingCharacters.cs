using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    class AlternatingCharacters
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string input = Console.ReadLine();
                int count = 0;
                int prev = 0;
                int current = 1;
                while (current < input.Length)
                {
                    if (input[prev] == input[current])
                    {
                        count++;
                        current++;
                    }
                    else
                    {
                        prev = current;
                        current++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
