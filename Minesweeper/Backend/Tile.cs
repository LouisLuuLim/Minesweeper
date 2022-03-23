using static Minesweeper.Backend.Enums;

namespace Minesweeper
{
    public class Tile
    {
        public int Value
        {
            get; protected set;
        }

        public TileState State
        {
            set; get;
        }

        public Tile()
        {
            State = TileState.Open;
        }
    }
}
