using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public class CPlane : CVehicle, IFly
    {
        public int Height { get; set; }
        public int NumberOfPassengers { get; set; }

        public CPlane(int price, int speed, int releaseYear, int height, int passsengers) : base(price, speed, releaseYear)
        {
            this.Height = height;
            this.NumberOfPassengers = passsengers;
        }

        public CPlane():this(0,0,0,0,0)
        {
        }

        public CPlane(int price, int speed, int releaseYear): this(price, speed, releaseYear, 0, 0)
        {

        }

        public void Fly()
        {
            Console.WriteLine("Plane is flying"); ;
        }
    }
}
