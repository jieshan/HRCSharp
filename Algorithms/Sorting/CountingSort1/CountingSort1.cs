using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort1
{
    class CountingSort1
    {
        static void Main(String[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(3000000)));
            int num = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] count = new int[100];
            for (int i = 0; i < num; i++)
            {
                count[int.Parse(numbers[i])]++;
            }
            Console.WriteLine(string.Join(" ", count));
        }
    }
}
