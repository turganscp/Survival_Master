using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBackEnd
{
    public class Tile
    {
        public Coordinate Coordinate {get; set;}

        public Tile(int row, int column)
        {
            Coordinate = new Coordinate(row, column);
        }

    }
}
