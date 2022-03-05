namespace Minesweeper.Backend.Difficulty
{
    public class Expert : IGameDifficulty
    {
        public int Mines => 99;
        public int Width => 30;
        public int Height => 16;
    }
}
