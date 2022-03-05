namespace Minesweeper.Backend.Difficulty
{
    public class Easy : IGameDifficulty
    {
        public int Mines => 10;
        public int Width => 9;
        public int Height => 9;
    }
}
