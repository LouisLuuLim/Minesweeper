namespace Minesweeper.Backend.Difficulty
{
    public class Intermediate : GameDifficulty
    {
        protected override int Mines => 40;
        protected override int Width => 16;
        protected override int Height => 16;
    }
}
