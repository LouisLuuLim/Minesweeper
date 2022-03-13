﻿using Minesweeper.Backend.MinesInitiator;
using System;
using System.Collections.Generic;
using static Minesweeper.Backend.Enums;

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

        public List<Coordinate> InitializeMines(IMinesInitiator minesInitiator, int minesCount, Coordinate firstSelectedCoordinate)
        {
            return minesInitiator.AddMines(_tiles, minesCount, firstSelectedCoordinate);
        }

        public void SelectTile(Coordinate coordinate)
        {
            var tileSate = _tiles[coordinate.Y, coordinate.X].State;

            if (tileSate == TileState.Closed || tileSate == TileState.MarkedAsClue)
            {
                return;
            }

            for (var x = Math.Max(0, coordinate.X - 1); x <= Math.Min(coordinate.X + 1, _width); x++)
            {
                for (var y = Math.Max(0, coordinate.Y - 1); y <= Math.Min(coordinate.Y + 1, _height); y++)
                {
                    if (x != coordinate.X && y != coordinate.Y)
                    {
                        _tiles[y, x].State = TileState.Closed;
                    }
                }
            }
        }
    }
}
