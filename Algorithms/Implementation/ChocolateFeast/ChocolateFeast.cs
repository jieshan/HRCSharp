using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class ChocolateFeast
    {
        static void Main(String[] args)
        {
            int m;
            m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int budget = int.Parse(input[0]);
                int price = int.Parse(input[1]);
                int wrapperNeeded = int.Parse(input[2]);
                int count = budget / price;
                int wrapper = count;
                while (wrapper / wrapperNeeded > 0)
                {
                    int additional = wrapper / wrapperNeeded;
                    count += additional;
                    wrapper += additional * (1 - wrapperNeeded);
                }
                Console.WriteLine(count);
            }
        }
    }
}
