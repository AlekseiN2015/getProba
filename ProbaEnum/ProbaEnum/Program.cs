using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaEnum
{
    class Program
    {
        enum orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        struct route
        {
            public orientation direction;
            public double distanse;
        }


        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistanse;
            Console.WriteLine("1) North\n2) South\n3) East\n4) West");
            do
            {
                Console.WriteLine("Select s direction!");
                myDirection = Convert.ToInt32(Console.ReadLine());
            } while ((myDirection < 1) || (myDirection > 4));

            Console.WriteLine("Input a distanse!");
            myDistanse = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (orientation)myDirection;
            myRoute.distanse = myDistanse;
            Console.WriteLine("My Roud specifies a directoin of {0} and a" + "distanse {1}", myRoute.direction, myRoute.distanse);
             

            Console.ReadKey();
        }
    }
}
