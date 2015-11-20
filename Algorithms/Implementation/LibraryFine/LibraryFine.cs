using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFine
{
    class LibraryFine
    {
        static void Main(String[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            if (int.Parse(line1[2]) > int.Parse(line2[2]) ||
                (int.Parse(line1[2]) == int.Parse(line2[2]) && int.Parse(line1[1]) > int.Parse(line2[1])) ||
                (int.Parse(line1[2]) == int.Parse(line2[2]) && int.Parse(line1[1]) == int.Parse(line2[1]) && int.Parse(line1[0]) > int.Parse(line2[0])))
            {
                if (line1[2].Equals(line2[2]))
                {
                    if (line1[1].Equals(line2[1]))
                    {
                        Console.WriteLine(15 * Math.Abs(int.Parse(line1[0]) - int.Parse(line2[0])));
                    }
                    else
                    {
                        Console.WriteLine(500 * Math.Abs(int.Parse(line1[1]) - int.Parse(line2[1])));
                    }
                }
                else
                {
                    Console.WriteLine(10000);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
