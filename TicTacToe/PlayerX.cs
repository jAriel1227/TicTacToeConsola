using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerX : Player
    {
        public PlayerX(Color color) : base(color)
        {

        }
        public override string ToString()
        {
            return "X";
        }
    }
}
