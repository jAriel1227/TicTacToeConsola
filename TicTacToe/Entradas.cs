using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Entradas 
    {
        Match match = new Match();
        private int filas;
        private int columnas;
        private string posision1;
        private string posision2;

        public Entradas()
        {
            
        }
        public void validacion(string posision)
        {
            if (posision != "0" && posision != "1" && posision !="2")
            {
                throw new BoardException("Solo puedes ingresar las posisiones de filas y columnas desdes 0 al 2.");
               
            }            
           
        }
        public void EntradaDatos()
        {
            while (!match.matchIsFiniched)
            {
                try
                {
                    while (!match.matchIsFiniched)
                    {                    
                        try
                        {
                            Canvas.printBoard(match.board);
                            Console.WriteLine("Casillas Disponibles: " + match.numberOfPlayLeft);
                            Console.WriteLine("");
                            Console.WriteLine("Esperando que juegue el jugador: " + match.whoIsPlaying());
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese la fila, para el jugador: " + match.whoIsPlaying());
                            posision1 = Console.ReadLine();
                            //llamando el metodo de validacion
                            validacion(posision1);
                            filas = Int32.Parse(posision1);

                            Console.WriteLine("Ingrese la columna, para el jugador: " + match.whoIsPlaying());
                            posision2 = Console.ReadLine();
                            //llamando el metodo de validacion
                            validacion(posision2);
                            columnas = Int32.Parse(posision2);


                            match.makeMove(new Position(filas, columnas));
                            
                            Console.Clear();
                        }
                        catch (BoardException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine();
                            Console.WriteLine("Presiona cualquier tecla para que vuleva a Jugar...");
                            Console.ReadLine();

                        }
                        Console.Clear();
                    }
                }
                catch(BoardException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }
    }
}
