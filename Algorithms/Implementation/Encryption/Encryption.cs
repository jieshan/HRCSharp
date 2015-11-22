using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Encryption
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int size = (int)Math.Floor(Math.Sqrt(s.Length));
            int columns = Math.Pow(size, 2) >= s.Length ? size : size + 1;
            int rows = columns * size >= s.Length ? size : columns;
            string[,] matrix = new string[rows, columns];
            int row = 0;
            int col = 0;
            for (int i = 0; i < s.Length; i++)
            {
                matrix[row, col % columns] = s[i].ToString();
                col++;
                if (col % columns == 0)
                {
                    row++;
                }
            }
            string output = "";
            for (int i = 0; i < columns; i++)
            {
                string group = "";
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j, i] != null)
                    {
                        group += matrix[j, i];
                    }
                }
                output += output.Length > 0 ? " " + group : group;
            }
            Console.WriteLine(output);
        }
    }
}
