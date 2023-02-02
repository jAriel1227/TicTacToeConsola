using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Canvas
    {
        public static void printBoard(Board b)
        {
            Console.WriteLine("----Tic Tac Toe X|O-----");
            Console.WriteLine("");
            Console.WriteLine("   ....................");
            Console.WriteLine("0" + "    {0}   |   {1}   |   {2}", b.board[0, 0], b.board[0, 1], b.board[0,2]);
            Console.WriteLine("   --------------------");
            Console.WriteLine("1" + "    {0}   |   {1}   |   {2}", b.board[1, 0], b.board[1, 1], b.board[1, 2]);
            Console.WriteLine("   --------------------");
            Console.WriteLine("2" + "    {0}   |   {1}   |   {2}", b.board[2, 0], b.board[2, 1], b.board[2, 2]);
            Console.WriteLine("   ....................");
            Console.WriteLine("     0     1      2");
            Console.WriteLine("------------------------");
        }
    }
}
