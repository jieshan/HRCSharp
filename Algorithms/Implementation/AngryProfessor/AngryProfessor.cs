using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class AngryProfessor
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string[] setup = Console.ReadLine().Split(' ');
                int req = int.Parse(setup[1]);
                string[] arrivals = Console.ReadLine().Split(' ');
                int count = 0;
                for (int j = 0; j < arrivals.Length; j++)
                {
                    int arrival = int.Parse(arrivals[j]);
                    if (arrival <= 0) 
                    {
                        count++;
                    }
                    if (count >= req)
                    {
                        break;
                    }
                }
                if (count >= req)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
