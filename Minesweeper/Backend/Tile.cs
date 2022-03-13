using static Minesweeper.Backend.Enums;

namespace Minesweeper
{
    public class Tile
    {
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
