using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class GameEngine
    {

        private Level Level;
        private int NumberOfLevels;
        

        public int MIN_SIZE = 10;
        public int MAX_SIZE = 20;


        public GameEngine(int levels) // construvtor which initializes number of levels field
        {

            NumberOfLevels = levels;
            Random rnd = new Random();
           
           
            Level = new Level(rnd.Next(MIN_SIZE, MAX_SIZE + 1), rnd.Next(MIN_SIZE, MAX_SIZE + 1));//genrating a random numbers between max and min value to create a level

        }

        public override string ToString()
        {
            

            return Level.ToString(); ;

        }
    }
}
