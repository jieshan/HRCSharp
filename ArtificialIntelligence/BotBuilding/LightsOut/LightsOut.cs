using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut
{
    class LightsOut
    {
        static void nextMove(int player, String[] board)
        {
            for (int i = 0; i < board.Length; i++) 
            {
                string input = board[i];
                if (input.Contains("1"))
                {
                    Console.WriteLine(i + " " + input.IndexOf("1"));
                    return;
                }
            }
        }

        static void Main(String[] args)
        {
            int player;

            //If player is 1, I'm the first player.
            //If player is 2, I'm the second player.
            player = int.Parse(Console.ReadLine());

            //Read the board now. The board is a 8x8 array filled with 1 or 0.
            String[] board = new String[8];
            for (int i = 0; i < 8; i++)
            {
                board[i] = Console.ReadLine();
            }

            nextMove(player, board);

        }
    }
}
