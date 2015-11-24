using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort3
{
    class CountingSort3
    {
        static void Main(String[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(3000000)));
            int num = int.Parse(Console.ReadLine());
            int[] count = new int[100];
            for (int i = 0; i < num; i++)
            {
                count[int.Parse(Console.ReadLine().Split(' ')[0])]++;
            }
            string output = "" + count[0];
            int[] total = new int[100];
            total[0] = count[0];
            for (int i = 1; i < count.Length; i++)
            {
                total[i] = count[i] + total[i - 1];
                output += " " + total[i];
            }
            Console.WriteLine(output);
        }
    }
}
