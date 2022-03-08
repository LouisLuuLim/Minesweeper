using System;
using System.Windows;

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

        public void InitializeMines(int x, int y, int minesCount)
        {
            _tiles[y, x] = new MineTile();
            minesCount--;

            var randomGenerator = new Random();

            for (int i = minesCount - 1; i >= 0; i--)
            {
                x = randomGenerator.Next(_width);
                y = randomGenerator.Next(_height);

                _tiles[y, x] = new MineTile();
            }
        }
    }
}
