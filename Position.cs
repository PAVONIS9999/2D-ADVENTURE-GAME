using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class Position
    {
        //Private Field Declaration for x and y coordinates
        private int xcord;
        private int ycord;

        public Position(int X, int Y) //constructor with 2 parameters
        {
            xcord = X;
            ycord = Y;

        }
        //properties for x and y coordinates

        public int Xcord
        { get; set; }

        public int Ycord
        { get; set; }

    }
}
