namespace Minesweeper.Backend
{
    public abstract class GameDifficulty
    {
        protected abstract int Mines { get; }
        protected abstract int Width { get; }
        protected abstract int Height { get; }
    }
}
