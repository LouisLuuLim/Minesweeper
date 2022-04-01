using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper.Backend.MinesInitiator
{
    public class InitialCoordinateSelectedMinesInitiator : IMinesInitiator
    {
        private Random _randomGenerator;

        public InitialCoordinateSelectedMinesInitiator()
        {
            _randomGenerator = new Random();
        }

        public InitialCoordinateSelectedMinesInitiator(int seed)
        {
            _randomGenerator = new Random(seed);
        }

        public Coordinate[] CreateMines(Tile[,] board, int minesCount, Coordinate firstSelectedPoint)
        {
            board[firstSelectedPoint.Y, firstSelectedPoint.X] = new MineTile();
            minesCount--;

            var boardHeight = board.Length;
            var boardWidth = board.GetLength(0);
            var minesCoordinates = CreateMinesCoordinates(minesCount, boardWidth, boardHeight);

            AddMines(board, minesCoordinates);

            return minesCoordinates;
        }

        public Coordinate[] CreateMinesCoordinates(int minesCount, int boardWidth, int boardHeight)
        {
            var maxIndex = boardHeight * boardWidth;
            var minesCoordinates = new Coordinate[minesCount];
            var mineLocationCandidates = Enumerable.Range(0, maxIndex).ToList();

            for (int i = 0; i < minesCount; i++)
            {
                var nextCandidate = _randomGenerator.Next(mineLocationCandidates.Count);
                var nextMineIndex = mineLocationCandidates[nextCandidate];
                mineLocationCandidates.RemoveAt(nextCandidate);
                var mineCoordinate = GetCoordinatesFromMineLocationCandidateIndex(nextMineIndex, boardWidth, boardHeight);
                minesCoordinates[i] = mineCoordinate;
            }

            return minesCoordinates;
        }

        private Coordinate GetCoordinatesFromMineLocationCandidateIndex(int candidateIndex, int width, int height)
        {
            var coordinateY = candidateIndex / height;
            var coordinateX = candidateIndex % width;

            return new Coordinate(coordinateX, coordinateY);
        }

        public void AddMines(Tile[,] board, Coordinate[] minesCoordinates)
        {
            for (int i = 0; i < minesCoordinates.Length; i++)
            {
                var mineCoordinate = minesCoordinates[i];
                board[mineCoordinate.Y, mineCoordinate.X] = new MineTile();
            }
        }
    }
}
