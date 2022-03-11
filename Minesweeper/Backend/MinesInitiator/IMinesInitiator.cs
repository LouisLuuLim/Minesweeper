namespace Minesweeper.Backend.MinesInitiator
{
    public interface IMinesInitiator
    {
        void AddMines(Tile[,] tiles, int minesCount, Coordinate firstSelectedPoint);
    }
}
