using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaPreobrazovaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult = 0, shortVal = 4;
            int integerVal = 67;
            long longResult = 0;
            float floatVal = 10.5f;
            double doubleResult = 0, doubleVal = 99.999;
            string stringResult = String.Empty, stringVal = "17";
            bool boolVal = true;

            Console.WriteLine("Veriable Conversion Examples");
            doubleResult = floatVal*shortVal;
            Console.WriteLine("Implicit, -> double = {0} * {1} -> {2}", floatVal, shortVal, doubleResult);

            shortResult = (short)floatVal;
            Console.WriteLine("Explisit, -> short {0} -> {1}", floatVal, shortResult);

            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine("Explisit -> string : \"{0}\" + \"{1}\" -> {2}", boolVal, doubleVal, stringResult);

            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixd, ->long: {0} + {1} -> {2}", integerVal, stringVal, longResult);
            Console.ReadKey();
        }
    }
}
