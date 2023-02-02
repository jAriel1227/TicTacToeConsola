using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Match
    {
        public Board board { get; set; }
        public Color currentPlayer;
        public int numberOfPlayLeft = 9;
        public bool matchIsFiniched = false;
        public Match()
        {
            board = new Board(3, 3);
            currentPlayer = Color.Black;
        }
        public void changePlayer()
        {
            if (currentPlayer == Color.Black)
            {
                currentPlayer = Color.White;
            }
            else
            {
                currentPlayer = Color.Black;
            }            
        }
        public Player whoIsPlaying()
        {
            if(currentPlayer == Color.Black)
            {
                return new PlayerO(Color.Black);
            }
            else
            {
                return new PlayerX(Color.Black);
            }
        }
        public void makeMove(Position movePos)
        {
            checkWinner();
            board.placePlayerAt(whoIsPlaying(), movePos);
            numberOfPlayLeft--;
            changePlayer();
        }
        public void checkWinner()
        {
            //Validacion de forma horizontal
            for (int i = 0; i < 3; i++)
            {
                  if (board.boardPos(i, 0) != null && board.board[i, 0] == board.board[i, 1] && board.board[i, 1] == board.board[i, 2])
                  {
                      Console.WriteLine("Ha ganado el jugador: " + board.board[i, 0]);
                      Console.WriteLine();
                      Console.Read();                    
                      matchIsFiniched = true;
                  } 
            }
            //Validacion de forma vertical
            for (int i = 0; i < 3; i++)
            {               
                
                  if (board.boardPos(0, i) != null && board.board[0, i] == board.board[1, i] && board.board[1, i] == board.board[2, i])
                  {
                     Console.WriteLine("Ha ganado el jugador: " + board.board[0, i]);
                     Console.WriteLine();
                     Console.Read();
                     matchIsFiniched = true;
                  }
                               
            }
            //Validacion Diagonal  
            //Izquierda a derecha
            if(board.boardPos(0, 0) != null)
            {
                if (board.board[0, 0] == board.board[1, 1] && board.board[1, 1] == board.board[2, 2])
                {
                    Console.WriteLine("Ha ganado el jugador: " + board.board[0, 0]);
                    Console.WriteLine();
                    Console.Read();
                    matchIsFiniched = true;
                }
            }           

            //Derecha a Izquierda
            if(board.boardPos(0, 2) != null)
            {
                if (board.board[0, 2] == board.board[1, 1] && board.board[1, 1] == board.board[2, 0])
                {
                    Console.WriteLine("Ha ganado el jugador: " + board.board[0, 2]);
                    Console.WriteLine();
                    Console.Read();
                    matchIsFiniched = true;
                }
            }            
            if(numberOfPlayLeft == 0)
            {
                Console.WriteLine("El juego esta empatado. Inicia nuevamente otra partida.");
                Console.WriteLine();
                matchIsFiniched = true;
            }
        }
    }
}
