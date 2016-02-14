using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaArrayList2
{
    class Cow : Animal
    {
        public void Milk()
        {
            Console.WriteLine("{0} было подоено!", name);
        }

        public Cow(string newName) : base(newName)
        {

        }
    }
}
