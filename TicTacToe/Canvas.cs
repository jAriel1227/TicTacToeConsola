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
            Console.WriteLine("----Bienvenido al juego-----");
            Console.WriteLine("");
            Console.WriteLine("   ...................");
            Console.WriteLine("C" + "    {0}   |   {1}   |   {2}", b.board[0, 0], b.board[0, 1], b.board[0,2]);
            Console.WriteLine("   --------------------");
            Console.WriteLine("B" + "    {0}   |   {1}   |   {2}", b.board[1, 0], b.board[1, 1], b.board[1, 2]);
            Console.WriteLine("   --------------------");
            Console.WriteLine("A" + "    {0}   |   {1}   |   {2}", b.board[2, 0], b.board[2, 1], b.board[2, 2]);
            Console.WriteLine("   ...................");
            Console.WriteLine("     A     B      C");
            Console.WriteLine("------------------------");
        }
    }
}
