using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiddingGame
{
    class TheBiddingGame
    {
        static int calculate_bid(int player, int pos, int[] first_moves, int[] second_moves)
        {
            int firstMoney = 100;
            int secondMoney = 100;
            bool winOnDraw = true;
            for (int i = 0; i < first_moves.Length; i++)
            {
                if (first_moves[i] > second_moves[i])
                {
                    firstMoney -= first_moves[i];
                }
                else if (first_moves[i] < second_moves[i])
                {
                    secondMoney -= second_moves[i];
                }
                else
                {
                    firstMoney -= winOnDraw ? first_moves[i] : 0;
                    secondMoney -= winOnDraw ? 0 : second_moves[i];
                    winOnDraw = !winOnDraw;
                }
            }
            int ownMoney = player == 1 ? firstMoney : secondMoney;
            int opponentMoney = player == 1 ? secondMoney : firstMoney;
            winOnDraw = player == 1 ? winOnDraw : !winOnDraw;
            int toWin = player == 1 ? pos : 10 - pos;
            if (ownMoney == 0)
            {
                return 0;
            }
            if (opponentMoney == 0)
            {
                return 1;
            }
            // Borrowed from kshi's algo
            double[] fractions = new double[] { 0, 1, 0.366025, 0.211325, 0.154701, 0.133975 };
            double baseBid;
            if (toWin < 5)
            {
                baseBid = fractions[toWin] * ownMoney;
            }
            else if (toWin > 5)
            {
                baseBid = fractions[10 - toWin] * opponentMoney;
            }
            else
            {
                baseBid = fractions[5] * Math.Min(ownMoney, opponentMoney);
            }
            int bid = winOnDraw ? (int)Math.Min(Math.Floor(baseBid), ownMoney) : (int)Math.Min(Math.Floor(baseBid + 1.01), ownMoney);
            return (int)Math.Max(bid, 1);
        }

        static void Main(String[] args)
        {
            int player = int.Parse(Console.ReadLine());
            int scotch_pos = int.Parse(Console.ReadLine());
            int bid = 0;                                 //Amount bid by the players
            String first_move = Console.ReadLine();     //Previous moves made by the first player
            String second_move = Console.ReadLine();     //Previous moves made by the second player
            String[] move_1 = first_move.Split(' ');
            String[] move_2 = second_move.Split(' ');
            int[] first_moves = new int[200];
            int[] second_moves = new int[200];
            if (String.Compare(first_move, "") != 0)
            {
                for (int i = 0; i < move_1.Length; i++)
                {
                    first_moves[i] = Convert.ToInt32(move_1[i]);
                    second_moves[i] = Convert.ToInt32(move_2[i]);
                }
            }
            bid = calculate_bid(player, scotch_pos, first_moves, second_moves);
            Console.Write(bid);
        }
    }
}
