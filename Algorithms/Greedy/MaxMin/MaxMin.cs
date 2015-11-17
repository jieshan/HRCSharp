using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class MaxMin
    {
        static void Main(String[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int reach = int.Parse(Console.ReadLine());
            List<long> list = new List<long>();
            for (int i = 0; i < total; i++)
            {
                list.Add(long.Parse(Console.ReadLine()));
            }
            list.Sort();
            long diff = list.ElementAt(total - 1) - list.ElementAt(0);
            for (int i = 0; i < total - reach + 1; i++)
            {
                diff = Math.Min(diff, list.ElementAt(i + reach - 1) - list.ElementAt(i));
            }
            Console.WriteLine(diff);
        }
    }
}
