using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotClean
{
    class BotClean
    {
        static void next_move(int posr, int posc, String[] board)
        {
            int min = int.MaxValue;
            int trow = 0;
            int tcol = 0;
            for (int i = 0; i < board.Length; i++)
            {
                string row = board[i];
                for (int j = 0; j < row.Length; j++)
                {
                    if (row[j] == 'd') 
                    {
                        int dist = Math.Abs(posr - i) + Math.Abs(posc - j);
                        if (dist < min)
                        {
                            trow = i;
                            tcol = j;
                            min = dist;
                        }
                        if (min == 0)
                        {
                            break;
                        }
                    }
                }
                if (min == 0)
                {
                    break;
                }
            }
            if (trow != posr)
            {
                Console.WriteLine(trow < posr? "UP" : "DOWN");
            }
            else if (tcol != posc)
            {
                Console.WriteLine(tcol < posc ? "LEFT" : "RIGHT");
            }
            else 
            {
                Console.WriteLine("CLEAN");
            }
        }

        static void Main(String[] args)
        {
            String temp = Console.ReadLine();
            String[] position = temp.Split(' ');
            int[] pos = new int[2];
            String[] board = new String[5];
            for (int i = 0; i < 5; i++)
            {
                board[i] = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++) pos[i] = Convert.ToInt32(position[i]);
            next_move(pos[0], pos[1], board);
        }
    }
}
