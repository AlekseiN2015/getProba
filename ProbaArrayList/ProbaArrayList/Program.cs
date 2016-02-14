using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProbaArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание коллекции типа Array из объектов Animal и её использование.");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Бурёнка");

            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Дося");

            foreach (var animal in animalArray)
            {
                Console.WriteLine("Объект {0} был добавлен в коллекцию Array, " + "Имя = {1}.", animal.ToString(), animal.Name);
            }

            Console.WriteLine("Коллекция Array содержит {0} объектов.", animalArray.Length);
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            Console.WriteLine();
            Console.WriteLine("Сщздание коллекции объектов Animal типа Array и её использование.");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Таня");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Феня"));

            foreach(Animal myAnimal in animalArrayList)
            {
                Console.WriteLine("Объект {0}  был добавлен в коллекцию ArrayList, " + " Имя = {1}.", myAnimal.ToString(), myAnimal.Name);
            }
            Console.WriteLine("Коллекция ArrayList содержит {0} объктов.", animalArrayList.Count);
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Дополнительное манипулирование коллекцией ArrayList:");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEgg();
            Console.WriteLine("Животное по имени {0} находится под индексом {1}.", myCow1.Name, animalArrayList.IndexOf(myCow1));
            myCow1.Name = "Джанис";
            Console.WriteLine("Животное теперь зовут {0}!", ((Animal)animalArrayList[1]).Name);
            Console.ReadKey();
        }
    }
}
