using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaClassesAndInterfases
{
    class MyNewClass
    {
        
    }

    public abstract class MyBase
    {
        public string HelloWorld()
        {
            return "Hello World!!!";
        }
    }

    internal class MyClass : MyBase
    {

    }

    public interface IMyBaseInterface
    {

    }

    public interface IMyBaseInterface2
    {

    }

    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    {

    }

    internal sealed class MyComplexClass : MyClass, IMyInterface
    {

    }
}
