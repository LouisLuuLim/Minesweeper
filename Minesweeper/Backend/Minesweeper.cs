using Minesweeper.Backend;

namespace Minesweeper
{
    public class Minesweeper
    {
        private int _mineCount;

        private Board _board;

        public Minesweeper(IGameDifficulty gameDifficulty)
        {
            _board = new Board(gameDifficulty.Height, gameDifficulty.Width);
        }
    }
}
