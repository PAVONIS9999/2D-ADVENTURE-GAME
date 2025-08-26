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
        public Position x
        {
            get { return position; }         
                
        }

        public Position y
        {
            get { return position; }

        }

        public Tile(Position P) //constructor that accepts a position parameter type
        {
            position = P;

        }
    }
}
