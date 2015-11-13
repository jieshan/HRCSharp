using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Pangrams
    {
        static void Main(String[] args)
        {
            bool[] check = new bool[91];
            string input = Console.ReadLine().ToUpper();
            int count = 26;
            for (int i = 0; i < input.Length; i++)
            {
                int charAscii = (int)input[i];
                if (charAscii <= 90 && charAscii >= 65 && check[charAscii] != true)
                {
                    check[charAscii] = true;
                    count--;
                    if (count == 0)
                    {
                        Console.WriteLine("pangram");
                        return;
                    }
                }
            }
            Console.WriteLine("not pangram");
        }
    }
}
