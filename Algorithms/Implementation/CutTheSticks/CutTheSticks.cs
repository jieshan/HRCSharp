using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheSticks
{
    class CutTheSticks
    {
        static void Main(String[] args)
        {
            int total = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }
            while (list.Count > 0)
            {
                Console.WriteLine(list.Count);
                int currentMin = list.Min();
                list.RemoveAll(item => item == currentMin);
            }
        }
    }
}
