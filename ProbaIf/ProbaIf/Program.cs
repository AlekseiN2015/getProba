using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = String.Empty;
            double var1 = 0, var2 = 0;

            begin1:
                Console.WriteLine("Enter first number!");
            if (Double.TryParse(Console.ReadLine(), out var1) != true)
            {
                Console.WriteLine("You should enter double value!");
                goto begin1;
            }

            begin2:
                Console.WriteLine("Enter second number!");
            if (Double.TryParse(Console.ReadLine(), out var2) != true)
            {
                Console.WriteLine("You should enter double value!");
                goto begin2;
            }

            if (var1 < var2)
                result = "less than";
            else
            {
                result = var1 == var2 ? "equal to" : "greater than";
            }

            Console.WriteLine("The first number is {0} the second number!", result);
            Console.ReadKey();

        }
    }
}
