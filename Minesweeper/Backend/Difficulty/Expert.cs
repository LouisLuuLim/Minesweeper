namespace Minesweeper.Backend.Difficulty
{
    public class Expert : GameDifficulty
    {
        protected override int Mines => 99;
        protected override int Width => 30;
        protected override int Height => 16;
    }
}
