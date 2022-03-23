using System.Collections.Generic;

namespace Minesweeper.Backend.TilesInitiator.CluesInitator
{
    public interface ICluesInitiator
    {
        void AddClues(Tile[,] board, List<Coordinate> minesCoordinates);
    }
}
