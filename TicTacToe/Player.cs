using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        //Instancias de clases
        public Position position;
        public Color color;
        public Player( Color color)
        {
            position = null;
            this.color = color;
        }
    }
}
