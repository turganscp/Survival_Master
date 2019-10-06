using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBackEnd
{
    public abstract class Animal
    {
        public char Species { get; set; }
        protected char Gender { get; set; }
        protected int Weight { get; set; }
        protected bool Alive { get; set; }

        public Coordinate Coordinate { get; set; }

        public Animal(int row, int column)
        {
            Coordinate = new Coordinate(row, column);
        }


        public void Eat()
        {
            var TileThisAnimalIsOn = Tiles.Where(t => t.Coordinate == Animal.Coordinate).FirstOrDefault();

        }

    }
}
