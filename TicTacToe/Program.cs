using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();
            int row, columm;

            while(!match.matchIsFiniched)
            {
                try
                {
                    Canvas.printBoard(match.board);
                    Console.WriteLine("Casillas Disponibles: "+ match.numberOfPlayLeft);
                    Console.WriteLine("Esperando el jugador: " + match.whoIsPlaying());
                    Console.WriteLine("Ingrese la fila, para el jugador: "+match.whoIsPlaying());
                    string pos1 = Console.ReadLine();
                    row = Int32.Parse(pos1);
                    Console.WriteLine("Ingrese la columna, para el jugador: " + match.whoIsPlaying());
                    string pos2 = Console.ReadLine();
                    columm = Int32.Parse(pos2);
                    match.makeMove(new Position(row,columm));
                   
                    Console.Clear();
                }
                catch (BoardException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

            } 
        }
    }
}
