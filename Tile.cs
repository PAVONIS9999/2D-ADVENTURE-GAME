using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    abstract class Tile
    {
        private Position position; //private field of type position
        
            //properties to expose x and y values
        public int X
        {
            get { return position.Xcord; }         
                
        }

        public int Y
        {
            get { return position.Ycord; }

        }

        public Tile(Position Position) //constructor that accepts a position parameter type
        {
           position = Position;

        }
        //abstract property
        public abstract char Display
        { get; }
    }
}
