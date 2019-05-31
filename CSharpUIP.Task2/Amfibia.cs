using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public class Amfibia : CVehicle, IMove, ISwim
    {
        public Amfibia(int price, int speed, int releaseYear) : base(price, speed, releaseYear)
        {
        }

        public void Move()
        {
            Console.WriteLine("Amfibia is mobing"); ;
        }

        public void Swim()
        {
            Console.WriteLine("Amfibia is swimming"); ;
        }
    }
}
