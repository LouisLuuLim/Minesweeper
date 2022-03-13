using System.Collections.Generic;

namespace Minesweeper.Backend.TilesInitiator.CluesInitator
{
    interface ICluesInitiator
    {
        void AddClues(Tile[,] board, List<Coordinate> minesCoordinates);
    }
}
