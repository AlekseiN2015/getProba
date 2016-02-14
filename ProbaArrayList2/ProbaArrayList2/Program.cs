using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Джек"));
            animalCollection.Add(new Chicken("Вера"));

            foreach(Animal animal in animalCollection)
            {
                animal.Feed();
            }
            Console.ReadKey();
        }
    }
}
