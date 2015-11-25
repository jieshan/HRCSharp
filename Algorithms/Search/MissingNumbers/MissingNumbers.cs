using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{
    class MissingNumbers
    {
        static void Main(String[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput((int)Math.Pow(10, 10))));
            int[] numbers = new int[201];
            int baseline = -1;
            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(input[i]);
                if (baseline < 0)
                {
                    baseline = current;
                    numbers[100]++;
                }
                else 
                {
                    numbers[100 + current - baseline]++;
                }
            }
            count = int.Parse(Console.ReadLine());
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(input[i]);
                numbers[100 + current - baseline]--;
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 200; i++)
            {
                if (numbers[i] < 0)
                {
                    builder.Append((baseline + i - 100) + " ");
                }
            }
            Console.WriteLine(builder.ToString().Substring(0, builder.Length - 1));
        }
    }
}
