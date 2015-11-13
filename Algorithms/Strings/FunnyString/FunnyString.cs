using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyString
{
    class FunnyString
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                testFunnyString(Console.ReadLine().ToCharArray());
            }
        }

        static void testFunnyString(char[] input)
        {
            int lastInd = input.Length - 1;
            for (int i = 1; i <= lastInd; i++)
            {
                if (Math.Abs((int)input[i] - (int)input[i - 1]) != Math.Abs((int)input[lastInd - i] - (int)input[lastInd - i + 1]))
                {
                    Console.WriteLine("Not Funny");
                    return;
                }
            }
            Console.WriteLine("Funny");
        }
    }
}
