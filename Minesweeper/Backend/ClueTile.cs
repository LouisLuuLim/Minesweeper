namespace Minesweeper.Backend
{
    public class ClueTile : Tile
    {
        public ClueTile(int value)
        {
            Value = value;
        }

        public void Increment() => Value++;
    }
}
