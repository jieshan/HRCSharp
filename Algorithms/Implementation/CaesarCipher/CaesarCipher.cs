using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class CaesarCipher
    {
        static void Main(String[] args)
        {
            int len = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int skip = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 0; i < len; i++)
            {
                char current = input[i];
                if (current >= 'A' && current <= 'Z')
                {
                    current = (char)(current + skip);
                    while (current > 'Z')
                    {
                        current = (char)(current - 26);
                    }
                }
                else if (current >= 'a' && current <= 'z')
                {
                    current = (char)(current + skip);
                    while (current > 'z')
                    {
                        current = (char)(current - 26);
                    }
                }
                output += current;
            }
            Console.WriteLine(output);
        }
    }
}
