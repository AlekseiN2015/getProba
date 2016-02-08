using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaMetodov1
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxVol = intArray[0];
            for(int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVol)
                    maxVol = intArray[i];
                
            }
            return maxVol;
        }

        static int SumVal(params int[] vals)
        {
            int sum = 0;
            foreach(int val in vals)
            {
                sum += val;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 0, 9, 87, 556, 67, 39, 45, 698, 23, 78 };
            int maxVol = MaxValue(myArray);
            int sum = SumVal(myArray);
            Console.WriteLine("Sum myArray is {0}.", sum);
            Console.WriteLine("The maximum value in myArray is {0}.", maxVol);
            Console.ReadKey();
        }
    }
}
