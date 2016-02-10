using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOfGetAndSet
{
    class MyClass
    {
        public readonly string Name;
        private int intVal;
        public int Val
        {
            get { return intVal; }
            set
            {
                if (value >= 0 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
            }
        }

        public int MyInt
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nVal: " + Val;
        }

        public double MyMethod(double paramX, double paramY)
        {
            throw new System.NotImplementedException();
        }

        public MyClass (string newName)
        {
            Name = newName;
            intVal = 0;
        }
    }
}
