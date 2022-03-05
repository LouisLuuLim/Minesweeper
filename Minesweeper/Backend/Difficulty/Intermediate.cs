namespace Minesweeper.Backend.Difficulty
{
    public class Intermediate : IGameDifficulty
    {
        public int Mines => 40;
        public int Width => 16;
        public int Height => 16;
    }
}
