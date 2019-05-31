using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public class Coordinate
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate():this(0,0)
        {

        }
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"x={X}, y={Y}";
        }
    }
}
