using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Anagram
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string input = Console.ReadLine();
                if (input.Length % 2 != 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    int[] check = new int[123];
                    int start = 0;
                    int end = input.Length - 1;
                    while (end > start) 
                    {
                        check[(int)input[start]]++;
                        check[(int)input[end]]--;
                        start++;
                        end--;
                    }
                    int count = 0;
                    for (int j = 97; j < check.Length; j++)
                    {
                        if (check[j] != 0)
                        {
                            count += Math.Abs(check[j]);
                        }
                    }
                    Console.WriteLine(count / 2);
                }
            }
        }
    }
}
