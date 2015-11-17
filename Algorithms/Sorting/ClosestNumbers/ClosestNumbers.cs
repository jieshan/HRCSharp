using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestNumbers
{
    class ClosestNumbers
    {
        static void Main(String[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<long> list = new List<long>();
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < count; i++)
            {
                list.Add(long.Parse(input[i]));
            }
            list.Sort();
            long diff = list.ElementAt(count - 1) - list.ElementAt(0);
            string output = "";
            for (int i = 0; i < count - 1; i++)
            {
                if (list.ElementAt(i + 1) - list.ElementAt(i) < diff)
                {
                    output = list.ElementAt(i) + " " + list.ElementAt(i + 1);
                    diff = list.ElementAt(i + 1) - list.ElementAt(i);
                }
                else if (list.ElementAt(i + 1) - list.ElementAt(i) == diff)
                {
                    output += " " + list.ElementAt(i) + " " + list.ElementAt(i + 1);
                }
            }
            Console.WriteLine(output);
        }
    }
}
