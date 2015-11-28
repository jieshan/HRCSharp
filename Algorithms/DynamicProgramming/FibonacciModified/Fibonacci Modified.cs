using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FibonacciModified
{
    class FibonacciModified
    {
        static void Main(String[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            BigInteger A = new BigInteger(int.Parse(input[0]));
            BigInteger B = new BigInteger(int.Parse(input[1]));
            int N = int.Parse(input[2]);
            int curr = 3;
            BigInteger result = 0;
            while (curr <= N)
            {
                result = A + BigInteger.Pow(B, 2);
                A = B;
                B = result;
                curr++;
            }
            const int SPLIT_LIMIT = 1024;
            StringBuilder sb = new StringBuilder();
            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, SPLIT_LIMIT);

            while (result != 0)
            {
                ans.Add(result % p10);
                result /= p10;
            }
            sb.Append(ans[ans.Count - 1].ToString());

            var fmt = new string('0', SPLIT_LIMIT);

            for (var i = ans.Count - 2; i >= 0; i--)
            {
                var str = ans[i].ToString();
                sb.Append(String.Format("{0}{1}", fmt.Substring(0, SPLIT_LIMIT - str.Length), str));
            }
            Console.WriteLine(sb);
        }
    }
}
