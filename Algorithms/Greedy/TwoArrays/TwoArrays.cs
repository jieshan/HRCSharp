using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArrays
{
    class TwoArrays
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string[] setup = Console.ReadLine().Split(' ');
                int threshold = int.Parse(setup[1]);
                string[] array1 = Console.ReadLine().Split(' ');
                string[] array2 = Console.ReadLine().Split(' ');
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                for (int j = 0; j < array1.Length; j++)
                {
                    list1.Add(int.Parse(array1[j]));
                    list2.Add(int.Parse(array2[j]));
                }
                list1.Sort();
                list2.Sort();
                bool found = false;
                while (list1.Count > 0) 
                {
                    int current = list1.ElementAt(0);
                    found = false;
                    for (int j = 0; j < list2.Count; j++)
                    {
                        if (current + list2.ElementAt(j) >= threshold)
                        {
                            list2.RemoveAt(j);
                            list1.RemoveAt(0);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine("YES");
                }
            }          
        }
    }
}
