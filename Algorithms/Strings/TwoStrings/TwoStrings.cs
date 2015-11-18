using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class TwoStrings
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                int[] check = new int[123];
                for (int j = 0; j < input1.Length; j++)
                {
                    check[(int) input1[j]]++;
                }
                bool found = false;
                for (int j = 0; j < input2.Length; j++)
                {
                    if (check[(int)input2[j]] > 0)
                    {
                        found = true;
                        break;
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
