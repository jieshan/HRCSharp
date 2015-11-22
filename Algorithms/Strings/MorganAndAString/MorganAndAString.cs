using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorganAndAString
{
    class MorganAndAString
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                int current1 = 0;
                int current2 = 0;
                StringBuilder output = new StringBuilder();
                output.EnsureCapacity(first.Length + second.Length);
                while (current1 < first.Length && current2 < second.Length)
                {
                    if (first[current1] < second[current2])
                    {
                        output.Append(first[current1]);
                        current1++;
                    }
                    else if (first[current1] > second[current2])
                    {
                        output.Append(second[current2]);
                        current2++;
                    }
                    else
                    {
                        if (first.Substring(current1).CompareTo(second.Substring(current2)) < 0 )
                        {
                            output.Append(first[current1]);
                            current1++;
                        }
                        else
                        {
                            output.Append(second[current2]);
                            current2++;
                        }
                    }
                }
                if (current1 < first.Length)
                {
                    output.Append(first.Substring(current1));
                }
                else 
                {
                    output.Append(second.Substring(current2));
                }
                Console.WriteLine(output);
            }
        }
    }
}
