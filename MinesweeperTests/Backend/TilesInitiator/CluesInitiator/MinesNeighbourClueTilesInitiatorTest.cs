using Minesweeper;
using Minesweeper.Backend;
using Minesweeper.Backend.Difficulty;
using Minesweeper.Backend.MinesInitiator;
using Minesweeper.Backend.TilesInitiator.CluesInitator;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MinesweeperTests.Backend.TilesInitiator.CluesInitiator
{
    [TestFixture]
    public class MinesNeighbourClueTilesInitiatorTest
    {
        [Test]
        public void Should_ReturnBoardWithMines_At_GivenLocation()
        {
            // Arrange
            var easyDifficulty = new Easy();
            var board = CreateBoardInitialState(easyDifficulty.Height, easyDifficulty.Width);
            var minesLocation = CreateMinesCoordinates();
            var boardMineInitiator = new InitialCoordinateSelectedMinesInitiator();
            var boardClueInitiator = new MinesNeighbourClueTilesInitiator();

            // Act
            boardMineInitiator.AddMines(board, minesLocation.ToArray());
            boardClueInitiator.AddClues(board, minesLocation);

            // Assert
            var expectedCluesCoordinates = CreateCluesCoordinatesExpectedResult();
            PrintBoard(board);
            foreach (var (clueCoordinate, expectedClueValue) in expectedCluesCoordinates)
            {
                Assert.That(board[clueCoordinate.Y, clueCoordinate.X].Value, Is.EqualTo(expectedClueValue));
            }
        }

        private void PrintBoard(Tile[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j].Value + " | ");
                }

                Console.WriteLine();
            }
        }

        private Tile[,] CreateBoardInitialState(int height, int width)
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

        private List<Coordinate> CreateMinesCoordinates()
        {
            return new List<Coordinate>
            {
                new Coordinate(0, 1),
                new Coordinate(8, 1),
                new Coordinate(0, 2),
                new Coordinate(2, 4),
                new Coordinate(8, 4),
                new Coordinate(1, 5),
                new Coordinate(2, 5),
                new Coordinate(5, 5),
                new Coordinate(0, 6),
                new Coordinate(5, 7),
            };
        }

        private Dictionary<Coordinate, int> CreateCluesCoordinatesExpectedResult()
        {
            var cluesCoordinates = new Dictionary<Coordinate, int>
            {
                { new Coordinate(0, 0), 1 },
                { new Coordinate(1, 0), 1 },
                { new Coordinate(7, 0), 1 },
                { new Coordinate(8, 0), 1 },
                { new Coordinate(1, 1), 2 },
                { new Coordinate(7, 1), 1 },
                { new Coordinate(1, 2), 2 },
                { new Coordinate(7, 2), 1 },
                { new Coordinate(8, 2), 1 },
                { new Coordinate(0, 3), 1 },
                { new Coordinate(1, 3), 2 },
                { new Coordinate(2, 3), 1 },
                { new Coordinate(3, 3), 1 },
                { new Coordinate(7, 3), 1 },
                { new Coordinate(8, 3), 1 },
                { new Coordinate(0, 4), 1 },
                { new Coordinate(1, 4), 3 },
                { new Coordinate(3, 4), 2 },
                { new Coordinate(4, 4), 1 },
                { new Coordinate(5, 4), 1 },
                { new Coordinate(6, 4), 1 },
                { new Coordinate(7, 4), 1 },
                { new Coordinate(8, 4), 1 },
                { new Coordinate(0, 5), 2 },
                { new Coordinate(3, 5), 2 },
                { new Coordinate(4, 5), 1 },
                { new Coordinate(6, 5), 1 },
                { new Coordinate(7, 5), 1 },
                { new Coordinate(8, 5), 1 },
                { new Coordinate(1, 6), 3 },
                { new Coordinate(2, 6), 2 },
                { new Coordinate(3, 6), 1 },
                { new Coordinate(4, 6), 2 },
                { new Coordinate(5, 6), 2 },
                { new Coordinate(6, 6), 2 },
                { new Coordinate(0, 7), 1 },
                { new Coordinate(1, 7), 1 },
                { new Coordinate(4, 7), 1 },
                { new Coordinate(6, 7), 1 },
                { new Coordinate(4, 8), 1 },
                { new Coordinate(5, 8), 1 },
                { new Coordinate(6, 8), 1 },
            };


            return cluesCoordinates;
        }
    }
}
