using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGridSearch
{
    class TheGridSearch
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int k = 0; k < numCases; k++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int R = int.Parse(input[0]);
                int C = int.Parse(input[1]);
                string[] large = new string[R];
                for (int i = 0; i < R; i++)
                {
                    large[i] = Console.ReadLine();
                }
                input = Console.ReadLine().Split(' ');
                int r = int.Parse(input[0]);
                int c = int.Parse(input[1]);
                string[] small = new string[r];
                for (int i = 0; i < r; i++)
                {
                    small[i] = Console.ReadLine();
                }
                bool found = false;
                for (int i = 0; i < R; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        if (i + r <= R && j + c <= C && large[i][j] == small[0][0])
                        {
                            if (checkMatch(large, small, i, j))
                            {
                                found = true;
                                break;
                            }
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                Console.WriteLine(found ? "YES" : "NO");
            }
            Console.ReadLine();
        }

        static bool checkMatch(string[] large, string[] small, int i, int j)
        {
            for (int m = 0; m < small.Length; m++)
            {
                for (int n = 0; n < small[0].Length; n++)
                {
                    if (large[i + m][j + n] != small[m][n])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
