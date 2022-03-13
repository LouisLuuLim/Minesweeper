namespace Minesweeper.Backend
{
    public class ClueTile : Tile
    {
        public int Value
        {
            get; private set;
        }

        public ClueTile(int value)
        {
            Value = value;
        }

        public void Increment() => Value++;
    }
}
