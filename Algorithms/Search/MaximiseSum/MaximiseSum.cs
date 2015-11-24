using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximiseSum
{
    class MaximiseSum
    {
        static void Main(String[] args)
        {
            // Java has more suitable tree set features in this case
            Console.SetIn(new StreamReader(Console.OpenStandardInput((int) Math.Pow(10, 20))));
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int len = int.Parse(input[0]);
                ulong mod = ulong.Parse(input[1]);
                string[] array = Console.ReadLine().Split(' ');
                ulong[] prefix = new ulong[len];
                ulong curr = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    curr = (ulong.Parse(array[j]) % mod + curr) % mod;
                    prefix[j] = curr;
                }
                SortedList<ulong, string> cache = new SortedList<ulong, string>();
                ulong ret = 0;
                for(int k = 0; k < len; k++) 
                {
                    ret = Math.Max(ret, prefix[k]);
                    if (!cache.ContainsKey(prefix[k]))
                    {
                        cache.Add(prefix[k], "");
                    }
                    int next = cache.IndexOfKey(prefix[k]) + 1;
                    if (next < cache.Count)
                    {
                        ret = Math.Max(ret, prefix[k] - cache.Keys[next] + mod);
                    }
                }
                Console.WriteLine(ret);
            }
        }
    }
}
