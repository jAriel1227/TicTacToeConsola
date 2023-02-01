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
            board.placePlayerAt(whoIsPlaying(), movePos);
            numberOfPlayLeft--;
            changePlayer();

           /* if (numberOfPlayLeft == 0 && movePos != null)
            {
                throw new BoardException("No hay mas posiciones disponibles, el juego a terminado.");
            }*/
        }
    }
}
