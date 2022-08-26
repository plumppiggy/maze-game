using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    public class Grid
    {
        private int _Width;
        private int _Height;

        List<List<int>> _Grid { get; }

        Grid(int w, int h)
        {
            _Width = w;  
            _Height = h; 
            _Grid = new List<List<int>>();
            for (int i = 0; i < _Width; i++)
            {
                for (int j = 0; j < _Height; j++)
                {
                    _Grid[i].Add(0);
                }
            }

        }

        public int Width => _Width;
        public int Height => _Height;

        int GetSquare(int r, int c)
        {
            return _Grid[r][c];
        }













    }
}
