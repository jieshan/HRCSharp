using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class ServiceLane
    {
        static void Main(String[] args)
        {
            string[] setup = Console.ReadLine().Split(' ');
            int numCases = int.Parse(setup[1]);
            string[] lane = Console.ReadLine().Split(' ');
            for (int i = 0; i < numCases; i++)
            {
                string[] test = Console.ReadLine().Split(' ');
                int start = int.Parse(test[0]);
                int end = int.Parse(test[1]);
                int vehicle = 3;
                for (int j = start; j <= end; j++)
                {
                    int width = int.Parse(lane[j]);
                    if (width < vehicle)
                    {
                        vehicle = width;
                    }
                }
                Console.WriteLine(vehicle);
            }
        }
    }
}
