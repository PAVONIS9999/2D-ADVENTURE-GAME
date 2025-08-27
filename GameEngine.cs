using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class GameEngine
    {

        private Level Level1;
        private int NumberOfLevels;
        private int Random;

        public int MIN_SIZE = 10;
        public int MAX_SIZE = 20;


        public GameEngine(int levels)
        {

            NumberOfLevels = levels;

            Level1 = new Level(MIN_SIZE, MAX_SIZE);

        }

        public override string ToString()
        {
            string currentLevel = Level1.ToString();

           

            return currentLevel;




        }
    }
}
