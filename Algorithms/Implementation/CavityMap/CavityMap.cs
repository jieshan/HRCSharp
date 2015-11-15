using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavityMap
{
    class CavityMap
    {
        static void Main(String[] args)
        {
            int dim = int.Parse(Console.ReadLine());
            string[] input = new string[dim];
            string[,] check = new string[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                input[i] = Console.ReadLine();
            }
            if (dim < 3) 
            {
                printMap(input);
                return;
            }
            for (int i = 1; i < dim - 1; i++)
            {
                for (int j = 1; j < dim - 1; j++)
                {
                    if (check[i, j] == null) 
                    {
                        int current = int.Parse(input[i][j].ToString());
                        bool done = false;
                        if (!done && current <= int.Parse(input[i - 1][j].ToString()))
                        {
                            done = true;
                        }
                        else
                        {
                            check[i - 1, j] = "*";
                        }
                        if (!done)
                        {
                            if(current <= int.Parse(input[i][j + 1].ToString()))
                            {
                                done = true;
                            }
                            else
                            {
                                check[i, j + 1] = "*";
                            }
                        }
                        if (!done)
                        {
                            if (current <= int.Parse(input[i + 1][j].ToString()))
                            {
                                done = true;
                            }
                            else
                            {
                                check[i + 1, j] = "*";
                            }
                        }
                        if (!done)
                        {
                            if (current <= int.Parse(input[i][j - 1].ToString()))
                            {
                                done = true;
                            }
                            else
                            {
                                check[i, j - 1] = "*";
                            }
                        }                      
                        if (!done)
                        {
                            input[i] = input[i].Substring(0, j) + "X" + input[i].Substring(j + 1, dim - j - 1);
                        }
                    }
                }
            }
            printMap(input);
        }

        static void printMap(string[] map)
        {
            for (int i = 0; i < map.Length; i++)
            {
                Console.WriteLine(map[i]);
            }
        }
    }
}
