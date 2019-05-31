using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public class Batmobile : CVehicle, IMove, IFly
    {
        public Batmobile(int price, int speed, int releaseYear) : base(price, speed, releaseYear)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Batmobile is flying"); ;
        }

        public void Move()
        {
            Console.WriteLine("Batmobile is moving"); ;
        }
    }
}
