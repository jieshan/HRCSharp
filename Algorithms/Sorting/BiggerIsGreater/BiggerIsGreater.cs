using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerIsGreater
{
    class BiggerIsGreater
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int k = 0; k < numCases; k++)
            {
                string input = Console.ReadLine();
                int i = input.Length - 1;
                while (i > 0)
                {
                    if (input[i - 1] < input[i])
                    {
                        break;
                    }
                    i--;
                }
                if (i > 0)
                {
                    int j = input.Length - 1;
                    while (j >= i)
                    {
                        if (input[j] > input[i - 1])
                        {
                            break;
                        }
                        j--;
                    }
                    if (j >= i)
                    {
                        char[] output = input.ToCharArray();
                        char temp = output[i - 1];
                        output[i - 1] = output[j];
                        output[j] = temp;
                        j = output.Length - 1;
                        while (i < j)
                        {
                            temp = output[i];
                            output[i] = output[j];
                            output[j] = temp;
                            i++;
                            j--;
                        }
                        Console.WriteLine(String.Join("", output));
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }
                }
                else 
                {
                    Console.WriteLine("no answer");
                }
            }
        }
    }
}
