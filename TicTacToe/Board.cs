using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        public string[,] board;
        public Board( int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.board = new string[rows, columns];
        }

        //Posicion especifica...
        public string boardPos(Position position)
        {
            insideBoard(position);
            return board[position.row, position.column];
        }
        //Todas la posiciones 
        public string boardPos(int rows, int columms)
        {
            return board[rows, columms];
        }
        public bool positionIsOcuppied(Position pos)
        {
            return boardPos(pos) != null;
        }
        public void placePlayerAt(Player player, Position pos)
        {
            if(positionIsOcuppied(pos))
            {
                throw new BoardException("Esta posicion esta ocupada por el otro jugador.");
            }
            board[pos.row, pos.column] = player.ToString();
            player.position = pos;
        }
        public bool isOutOfBoard(Position pos)
        {
            if(pos.row <0 || pos.row >= rows || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }
        public void insideBoard(Position pos)
        {
            if (!isOutOfBoard(pos))
            {
                throw new BoardException("Posicion fuera de rango o del juego.");
            }            
        }
    }
}
