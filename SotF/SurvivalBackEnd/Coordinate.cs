using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalBackEnd
{
    public class Coordinate
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public static bool operator ==(Coordinate coordOne, Coordinate coordTwo)
        {
            if (coordOne.Row == coordTwo.Row && coordOne.Column == coordTwo.Column)
                return true;
            else
                return false;
        }

        public static bool operator !=(Coordinate coordOne, Coordinate coordTwo)
        {
            if (coordOne.Row != coordTwo.Row && coordOne.Column != coordTwo.Column)
                return true;
            else
                return false;
        }

        //you're basically telling C#: if you want to compare coordinates, do it in this specific way, not in however dumb way you end up doing
        //I can explain fairly easily
        //The standard == implementation doesn't compare the contents of an object
        //It does a bunch of technical nonsense and if it's not exactly the same, it'll tell you false
        //which means that if you do this:
        //Coordinate c = new Coordinate(1, 1);
        //Coordinate d = new Coordinate(1, 1);

        //it might not return true if you compare C and D, because they point to different memory locations
        //and the memory location is one of the things C# looks at for comparing shit

//        this is also useful if you have complex data objects, like for instance, someone's personal info
//but you only compare FirstName, LastName and DoB to check if they're the same
    }
}
