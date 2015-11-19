using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndTheBeast
{
    class SherlockAndTheBeast
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int temp = input;
                while (temp % 3 != 0)
                {
                    temp -= 5;
                }
                if (temp < 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat("5", temp)) + String.Concat(Enumerable.Repeat("3", input - temp)));
                }
            }
        }
    }
}
