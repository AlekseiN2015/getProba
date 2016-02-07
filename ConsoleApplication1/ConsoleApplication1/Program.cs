using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;

            Console.WriteLine("Enter your name, please.");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome, {0}", userName);
            Console.WriteLine("Give me a number!");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me another number!");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum of {0} and {1} is {2}!", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The substracting of {0} from {1} is {2}!", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} from {1} is {2}!", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The dividing of {0} from {1} is {2}!", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.ReadKey();
        }
    }
}
