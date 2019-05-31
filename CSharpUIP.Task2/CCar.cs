using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    public class CCar : CVehicle, IMove
    {
        public CCar(int price, int speed, int year):base(price, speed, year)
        {

        }

        public CCar():this(0,0,0)
        {

        }

        public void Move()
        {
            Console.WriteLine($"Car is moving"); ;
        }
    }
}
