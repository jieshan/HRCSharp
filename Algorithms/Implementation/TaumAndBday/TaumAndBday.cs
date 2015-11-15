using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaumAndBday
{
    class TaumAndBday
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string[] requirement = Console.ReadLine().Split(' ');
                long black = long.Parse(requirement[0]);
                long white = long.Parse(requirement[1]);
                string[] prices = Console.ReadLine().Split(' ');
                long blackPrice = long.Parse(prices[0]);
                long whitePrice = long.Parse(prices[1]);
                long convertPrice = long.Parse(prices[2]);
                long realBlackPrice = Math.Min(blackPrice, whitePrice + convertPrice);
                long realWhitePrice = Math.Min(whitePrice, blackPrice + convertPrice);
                Console.WriteLine((long) black*realBlackPrice + white*realWhitePrice);
            }
        }
    }
}
