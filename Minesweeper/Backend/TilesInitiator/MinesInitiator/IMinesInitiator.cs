using System.Collections.Generic;

namespace Minesweeper.Backend.MinesInitiator
{
    public interface IMinesInitiator
    {
        List<Coordinate> AddMines(Tile[,] board, int minesCount, Coordinate firstSelectedPoint);
    }
}
