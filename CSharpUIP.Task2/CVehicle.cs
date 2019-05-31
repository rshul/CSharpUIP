using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public abstract class CVehicle: IComparable<CVehicle>
    {

        public int Price { get; set; }
        public int Speed { get; set; }
        public int ReleaseYear { get; set; }
        private Coordinate Position { get; set; }

        protected CVehicle(int price, int speed, int releaseYear)
        {
            Price = price;
            Speed = speed;
            ReleaseYear = releaseYear;
            Position = new Coordinate();
        }

        public void SetCoordinate(int x, int y)
        {
            this.Position.X = x;
            this.Position.Y = y;
        }

        public string GetCoordinate()
        {
            return Position.ToString();
        }

        public override string ToString()
        {
            return $"This is {this.GetType().Name}";
        }

        public int CompareTo(CVehicle other)
        {
            return Price.CompareTo(other.Price);
        }
    }
}
