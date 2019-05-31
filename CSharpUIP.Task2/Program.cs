using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUIP.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CVehicle[] vehicles = new CVehicle[]
            {
                new CCar(500, 100, 1999),
                new CShip(1000, 30, 2010),
                new CPlane(10000, 1000, 2005),
                new CCar(300, 50, 1983),
                new CShip(9800, 30, 2000),
                new CPlane(9900, 800, 2013),
                new CPlane(3000, 300, 2001),
                new CCar(900, 120, 2010),
                new CCar(900, 120, 2017),
                new CCar(600, 120, 2016),
                new CCar(800, 120, 2019)
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

            int maxPrice = vehicles.Max((v) => v.Price);
            var goodVehicle = vehicles.Where((v) => v.ReleaseYear >= 2000 && v.ReleaseYear <= 2005)
                .Where(v => v.Speed > 150).OrderBy(v => v.Price).FirstOrDefault();

            Console.WriteLine(goodVehicle?.Price);

            var carsNotOlder5 = vehicles.Where(v => v is CCar).Where(v => 2019 - v.ReleaseYear < 5).OrderByDescending(v => v.Price).ToArray();
            foreach (var car in carsNotOlder5)
            {
                Console.WriteLine($"{car} {car.Price}");
            }

            IFly[] flyObjects = new IFly[]
           {
                new Batmobile(500, 100, 1999),
                new CPlane(1000, 30, 2010),
                new CPlane(10000, 1000, 2005),
                new Batmobile(300, 50, 1983),
                new CPlane(9900, 800, 2013),
                new CPlane(3000, 300, 2001),
                new Batmobile(900, 120, 2010),  
           };


            IMove[] moveObjects = new IMove[]
           {
                new Batmobile(500, 100, 1999),
                new CCar(900, 120, 2010),
                new CCar(900, 120, 2017),
                new Amfibia(600, 120, 2016),
                new CCar(800, 120, 2019),
                new Batmobile(300, 50, 1983),
                new Amfibia(900, 120, 2010),
           };

            ISwim[] swimObjects = new ISwim[]
            {
                new Amfibia(500, 100, 1999),
                new CShip(1000, 30, 2010),
                new Amfibia(10000, 1000, 2005),
                new Amfibia(300, 50, 1983),
                new CShip(9800, 30, 2000),
                
            };

           var sortedFlyObjects = flyObjects.Where(x => x is CVehicle).Select(x => (CVehicle)x).OrderBy(x => x.Price);
            foreach (var item in sortedFlyObjects)
            {
                Console.WriteLine(item.Price);
            }
            
            Array.Sort(flyObjects, ( o1, o2) => ((CVehicle) o1).Price.CompareTo(((CVehicle)o2).Price));
            foreach (var item in flyObjects)
            {
                Console.WriteLine($"{((CVehicle)item).Price}");
            }
                
        }
    }
}
