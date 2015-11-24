using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort2
{
    class CountingSort2
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
            string output = "";
            for (int i = 0; i < count.Length; i++)
            {
                output += String.Concat(Enumerable.Repeat(i + " ", count[i]));
            }
            Console.WriteLine(output.Substring(0, output.Length - 1));
        }
    }
}
