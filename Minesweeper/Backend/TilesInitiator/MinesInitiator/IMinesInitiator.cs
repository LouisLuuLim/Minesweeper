using System.Collections.Generic;

namespace Minesweeper.Backend.MinesInitiator
{
    public interface IMinesInitiator
    {
        List<Coordinate> AddMines(Tile[,] tiles, int minesCount, Coordinate firstSelectedPoint);
    }
}
