using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static _2D_ADVENTURE_GAME.Level;

namespace _2D_ADVENTURE_GAME
{
    internal class Level
    {
        //private fields for height and width values.
        private int height;
        private int width;
        //paralled or 2D array
        Tile[,] Array;


        //Properties to expose field values
        public int HeiGht
        {
            get { return height; }
        }
        public int WiDth
        {
            get { return width; }
        }

        public Level(int height, int width) //constructor
        {
            //initializing fields
            height = height;
            width = width;
            //initializing array using height and width values as the arrays dimensions
            Array = new Tile[width, height];
            InitialiseTiles();

        }

        public enum TileType
        {
            Empty


        }

        private Tile CreateTile(Tile tile, Position position, TileType tileType)
        {

            switch (tileType)
            {
                case TileType.Empty:
                    tile = new EmptyTile(position);
                    Array[width, height] = tile;
                    break;

                default:
                    break;
            }

            return tile;
        }
        private Tile CreateTile(Tile tile, int x, int y, TileType tileType)//overloading tile method
        {

            switch (tileType)
            {
                case TileType.Empty:
                    tile = new EmptyTile(new Position(x, y));
                    Array[width, height] = tile;
                    break;

                default:
                    break;
            }

            return tile;


        }

        public void InitialiseTiles() // initializeTiles method
        {
            foreach (Tile tile in Array)
            {
                CreateTile(tile, new Position(width, height), TileType.Empty);
            }


        }

        public override string ToString()
        {
            string longStr = "";
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {




                    longStr += Array[i, j].Display.ToString();



                }
                longStr += "\n";
            }

            return longStr;

        }

    }
}

