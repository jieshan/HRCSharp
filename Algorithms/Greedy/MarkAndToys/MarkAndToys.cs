using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkAndToys
{
    class MarkAndToys
    {
        static void Main(String[] args)
        {
            string[] setup = Console.ReadLine().Split(' ');
            long budget = long.Parse(setup[1]);
            string[] pricesInput = Console.ReadLine().Split(' ');
            List<long> prices = new List<long>();
            for (int i = 0; i < pricesInput.Length; i++)
            {
                prices.Add(long.Parse(pricesInput[i]));
            }
            prices.Sort();
            long count = 0;
            while (true)
            {
                if (budget - prices.ElementAt(0) >= 0)
                {
                    budget -= prices.ElementAt(0);
                    prices.RemoveAt(0);
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
