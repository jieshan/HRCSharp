using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string input = Console.ReadLine();
                int start = 0;
                int end = input.Length - 1;
                while (end > start)
                {
                    if (input[start] != input[end])
                    {
                        if (checkPalindrome(input, start + 1, end))
                        {
                            Console.WriteLine(start);
                        }
                        else 
                        {
                            Console.WriteLine(end);
                        }
                        break;
                    }
                    start++;
                    end--;
                }
                if (start >= end)
                {
                    Console.WriteLine(-1);
                }
            }
        }

        static bool checkPalindrome(string s, int start, int end)
        {
            while (end > start)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
