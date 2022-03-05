namespace Minesweeper.Backend
{
    public interface IGameDifficulty
    {
        public int Mines { get; }
        public int Width { get; }
        public int Height { get; }
    }
}
