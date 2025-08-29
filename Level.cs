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
        Tile[,] TileArray;


        //Properties to expose field values
        public int HeiGht
        {
            get { return height; }
        }
        public int WiDth
        {
            get { return width; }
        }

        public Level(int Height, int Width) //constructor
        {
            //initializing fields
            height = Height;
            width = Width;
            //initializing array using height and width values as the arrays dimensions
            TileArray = new Tile[width, height];
            InitialiseTiles();

        }

        public enum TileType
        {
            Empty


        }

        private Tile CreateTile(TileType tileType, Position position)
        {
            Tile tile;
       
            switch (tileType)
            {
                case TileType.Empty:
                    tile = new EmptyTile(position);

                    break;

                default:
                    return new EmptyTile(position);
                    break;

            }
             TileArray[position.Xcord, position.Ycord] = tile;
            return tile;

        }
        private Tile CreateTile( TileType tileType, int x, int y)//overloading tile method
        {

          Position position = new Position(x, y);  
            return CreateTile(tileType, position);

            


        }

        public void InitialiseTiles() // initializeTiles method
        {
             for (int i = 0; i < TileArray.GetLength(0); i++)
             {
                 for (int j = 0; j < TileArray.GetLength(1); j++)
                 {

                         TileArray[i, j] = CreateTile(TileType.Empty, i, j);



                 }

             } 
          



        }

        public override string ToString()
        {
            string longStr = "";
            for (int i = 0; i < TileArray.GetLength(0); i++)
            {
                for (int j = 0; j < TileArray.GetLength(1); j++)
                {




                    longStr += TileArray[i, j]?.Display ?? ' ';



                }
                longStr += "\n";
            }

            return longStr;

        }

    }
}

