using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper.Backend.MinesInitiator
{
    public class InitialCoordinateSelectedMinesInitiator : IMinesInitiator
    {
        public List<Coordinate>() AddMines(Tile[,] board, int minesCount, Coordinate firstSelectedPoint)
        {
            var minesCoordinates = new List<Coordinate>();
            var boardHeight = board.Length;
            var boardWidth = board.GetLength(0);
            var maxIndex = boardHeight * boardWidth;
            var mineLocationCandidates = Enumerable.Range(0, maxIndex).ToList();
            
            board[firstSelectedPoint.Y, firstSelectedPoint.X] = new MineTile();
            minesCount--;

            var randomGenerator = new Random();

            for (int i = minesCount - 1; i >= 0; i--)
            {
                var nextCandidate = randomGenerator.Next(mineLocationCandidates.Count);
                var nextMineIndex = mineLocationCandidates[nextCandidate];
                mineLocationCandidates.RemoveAt(nextCandidate);

                var mineCoordinate = GetCoordinatesFromMineLocationCandidateIndex(nextMineIndex, boardWidth, boardHeight);
                minesCoordinates.Add(mineCoordinate);
                board[mineCoordinate.Y, mineCoordinate.X] = new MineTile();
            }

            return minesCoordinates;
        }

        private Coordinate GetCoordinatesFromMineLocationCandidateIndex(int candidateIndex, int width, int height)
        {
            var coordinateY = candidateIndex / height;
            var coordinateX = candidateIndex % width;

            return new Coordinate(coordinateX, coordinateY);
        }
    }
}
