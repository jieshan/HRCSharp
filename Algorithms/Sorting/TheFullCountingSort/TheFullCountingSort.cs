using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFullCountingSort
{
    class TheFullCountingSort
    {
        static void Main(String[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(3000000)));
            int num = int.Parse(Console.ReadLine());
            int[] count = new int[100];
            int[] index = new int[num];
            string[] strings = new string[num];
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                index[i] = int.Parse(input[0]);
                strings[i] = input[1];
                count[index[i]]++;
            }
            int[] total = new int[100];
            total[0] = count[0];
            for (int i = 1; i < count.Length; i++)
            {
                total[i] = count[i] + total[i - 1];
            }
            int[] pointer = (int[])total.Clone();
            string[] output = new string[num];
            int firstPointer = 0;
            for (int i = 0; i < num; i++)
            {
                if (index[i] > 0)
                {
                    output[pointer[index[i] - 1]] = i < num / 2 ? "-" : strings[i];
                    pointer[index[i] - 1]++;
                }
                else
                {
                    output[firstPointer] = i < num / 2 ? "-" : strings[i];
                    firstPointer++;
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
