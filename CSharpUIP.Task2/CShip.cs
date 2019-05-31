using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public class CShip : CVehicle, ISwim
    {
        public string Port { get; set; }
        public int NumberOfPassengers { get; set; }

        public CShip(int price, int speed, int releaseYear, int numberOfPassengers, string port) : base(price, speed, releaseYear)
        {
            this.NumberOfPassengers = numberOfPassengers;
            this.Port = port;
        }

        public CShip():this(0,0,0,0,"NoName")
        {

        }

        public CShip(int price, int speed, int releaseYear) : this(price, speed, releaseYear, 0, "NoName")
        {

        }

        public void Swim()
        {
            Console.WriteLine("Ship is swimming"); ;
        }
    }
}
