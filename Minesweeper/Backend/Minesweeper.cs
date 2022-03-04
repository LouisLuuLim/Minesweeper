using System;

namespace Minesweeper
{
    public class Minesweeper
    {
        private int[] _board;
        private int _mineCount;
        

        public Minesweeper(int boardSize)
        {

            _board = new int[boardSize];
        }
    }
}
