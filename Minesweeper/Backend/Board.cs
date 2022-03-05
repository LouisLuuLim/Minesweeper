namespace Minesweeper.Backend
{
    public class Board
    {
        int _height;
        int _width;
        Tile[] _tiles;

        public Board(int height, int width)
        {
            _height = height;
            _width = width;
            _tiles = InitializeTiles(height, width);          
        }

        private Tile[] InitializeTiles(int height, int width)
        {
            var tiles = new Tile[height * width];

            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new Tile();
            }

            return tiles;
        }
    }
}
