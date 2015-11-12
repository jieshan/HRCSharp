using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class UtopianTree
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++) 
            {
                int numRounds = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(2, (Math.Ceiling((double) numRounds/2) + 1)) - (numRounds % 2 == 0 ? 1: 2) );
            }
            Console.ReadLine();
        }
    }
}
