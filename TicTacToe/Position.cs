using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Position
    {
        public int row { get; set; }
        public int column { get; set; }

        //Constructor
        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
