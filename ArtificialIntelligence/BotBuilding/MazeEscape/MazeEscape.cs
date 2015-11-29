using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeEscape
{
    class MazeEscape
    {
        static void Main(String[] args)
        {
            int player = int.Parse(Console.ReadLine());
            string[] maze = new string[3];
            for (int i = 0; i < 3; i++)
            {
                maze[i] = Console.ReadLine();
            }
            if (maze[1][2] != '-')
            {
                if (maze[1][2] == 'e')
                {
                    Console.WriteLine("RIGHT");
                    return;
                }
                else if (maze[2][1] != '#')
                {
                    Console.WriteLine("DOWN");
                    return;
                }
                else if (maze[1][0] != '#')
                {
                    Console.WriteLine("LEFT");
                    return;
                }
                else 
                {
                    Console.WriteLine("UP");
                    return;
                }
            }
            else if (maze[1][0] != '-')
            {
                if (maze[1][0] == 'e')
                {
                    Console.WriteLine("LEFT");
                    return;
                }
                else if (maze[0][1] != '#')
                {
                    Console.WriteLine("UP");
                    return;
                }
                else if (maze[1][2] != '#')
                {
                    Console.WriteLine("RIGHT");
                    return;
                }
                else
                {
                    Console.WriteLine("DOWN");
                    return;
                }
            }
            else
            {
                if (maze[0][0] == 'e' || maze[2][0] == 'e')
                {
                    Console.WriteLine("LEFT");
                    return;
                }
                else if (maze[0][2] == 'e' || maze[2][2] == 'e')
                {
                    Console.WriteLine("RIGHT");
                    return;
                }
                else
                {
                    Console.WriteLine("RIGHT");
                    return;
                }
            }
        }
    }
}
