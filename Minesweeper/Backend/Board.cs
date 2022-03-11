using Minesweeper.Backend.MinesInitiator;
using System;
using System.Linq;

namespace Minesweeper.Backend
{
    public class Board
    {
        int _height;
        int _width;
        Tile[,] _tiles;

        public Board(int height, int width)
        {
            _height = height;
            _width = width;
            _tiles = InitializeTiles(height, width);          
        }

        private Tile[,] InitializeTiles(int height, int width)
        {
            var tiles = new Tile[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    tiles[i, j] = new Tile();
                }
            }

            return tiles;
        }

        public void InitializeMines(IMinesInitiator minesInitiator, int minesCount, Coordinate firstSelectedCoordinate)
        {
            minesInitiator.AddMines(_tiles, minesCount, firstSelectedCoordinate);
        }
    }
}
