using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBackEnd
{
    public class SurvivalController
    {
        public List<Tile> Tiles { get; set; }

        public SurvivalController()
        {
            Tiles = new List<Tile>();
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Tiles.Add(new Tile(i, j));
                }
            }
        }
    }
}
