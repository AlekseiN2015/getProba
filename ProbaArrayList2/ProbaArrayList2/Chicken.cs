using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaArrayList2
{
    class Chicken : Animal
    {
        public void LayEgg()
        {
            Console.WriteLine("{0} снесло яйцо!", name);
        }

        public Chicken(string newName) : base(newName)
        {

        }
    }
}
