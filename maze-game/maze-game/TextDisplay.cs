using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    public class TextDisplay
    {
        Grid _TheGrid;
        int _Height;
        int _Width;

        TextDisplay(Grid grid)
        {
            _TheGrid = grid;
            _Width = grid.Width;
            _Height = grid.Height;
        }
        void PrintGrid()
        {
            for (int i = 0; i < _Height; i++)
            {
                for (int j = 0; j < _Width; j++)
                {
                    Console.WriteLine(_TheGrid.GetSquare(i, j));
                }
            }
        }
    }
}
