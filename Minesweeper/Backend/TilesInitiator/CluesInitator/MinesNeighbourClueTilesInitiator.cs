using System;
using System.Collections.Generic;

namespace Minesweeper.Backend.TilesInitiator.CluesInitator
{
    class MinesNeighbourClueTilesInitiator : ICluesInitiator
    {
        private const int ClueTileInitialValue = 1;

        public void AddClues(Tile[,] board, List<Coordinate> minesCoordinates)
        {
            var boardHeight = board.Length;
            var boardWidth = board.GetLength(0);

            foreach (var mineCoordinate in minesCoordinates)
            {
                for (var x = Math.Max(0, mineCoordinate.X - 1); x <= Math.Min(mineCoordinate.X + 1, boardWidth); x++)
                {
                    for (var y = Math.Max(0, mineCoordinate.Y - 1); y <= Math.Min(mineCoordinate.Y + 1, boardHeight); y++)
                    {
                        if (x != mineCoordinate.X && y != mineCoordinate.Y)
                        {
                            if (board[y, x] is ClueTile clueTile)
                            {
                                clueTile.Increment();
                            }
                            else
                            {
                                board[y, x] = new ClueTile(ClueTileInitialValue);
                            }
                        }
                    }
                }
            }
        }
    }
}
