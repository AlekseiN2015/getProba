using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaMas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Robert", "Mike", "Jeremy" };
            Console.WriteLine("Here are {0} of my frieds:", friendNames.Length);
            foreach (string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
            Console.ReadKey();
        }
    }
}
