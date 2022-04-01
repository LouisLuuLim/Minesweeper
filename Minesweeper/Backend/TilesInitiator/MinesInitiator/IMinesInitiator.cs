using System.Collections.Generic;

namespace Minesweeper.Backend.MinesInitiator
{
    public interface IMinesInitiator
    {
        Coordinate[] CreateMines(Tile[,] board, int minesCount, Coordinate firstSelectedPoint);
        Coordinate[] CreateMinesCoordinates(int minesCount, int boardWidth, int boardHeight);
        void AddMines(Tile[,] board, Coordinate[] minesCoordinates);
    }
}
