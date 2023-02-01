using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerO : Player
    {
        public PlayerO(Color color) : base(color)
        {

        }
        public override string ToString()
        {
            return "O";
        }
    }
}
