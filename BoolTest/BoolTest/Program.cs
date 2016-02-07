using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int myInt;
            Int32.TryParse(Console.ReadLine(), out myInt);
            Console.WriteLine("Integer less than 10? {0}", myInt < 10);
            Console.WriteLine("Integer between 0 and 5? {0}", ((0 <= myInt) && (myInt <= 5)));
            Console.ReadKey();
        }
    }
}
