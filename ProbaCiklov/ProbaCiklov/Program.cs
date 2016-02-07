using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaCiklov
{
    class Program
    {
        static void Main(string[] args)
        {
            double balanse = 0, interestRate = 0, targetBalanse = 0;
            Console.WriteLine("What is your current balanse?");
            Double.TryParse(Console.ReadLine(), out balanse);
            Console.WriteLine("What is your current annual interest rate?");
            Double.TryParse(Console.ReadLine(), out interestRate);
            interestRate = 1 + interestRate / 100.0;
            Console.WriteLine("What balanse whould you like to have?");
            Double.TryParse(Console.ReadLine(), out targetBalanse);

            int totalYears = 0;
            while (balanse < targetBalanse)
            {
                balanse *= interestRate;
                totalYears++;
            }

            Console.WriteLine("In {0} year{1} you will have a balanse of {2}!", totalYears, totalYears == 1 ? "" : "s", balanse);
            Console.ReadKey();
        }
    }
}
