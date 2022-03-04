namespace Minesweeper.Backend.Difficulty
{
    public class Easy : GameDifficulty
    {
        protected override int Mines => 10;
        protected override int Width => 9;
        protected override int Height => 9;
    }
}
