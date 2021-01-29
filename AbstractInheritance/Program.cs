using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    abstract public class AbstractBaseClass
    {
        abstract public void Output(string outputString);
    }

    public class SubClass1 : AbstractBaseClass
    {
        override public void Output(string source) 
        {
            string s = source.ToUpper();
            Console.WriteLine("Call to SubClass1.Output() from within {0}", s);
        }
    }

    public class SubClass2 : AbstractBaseClass
    {
        public override void Output(string source)  
        {
            string s = source.ToLower();
            Console.WriteLine("Call to SubClass2.Output() from within {0}", s);
        }
    }

    class Program
    {
        public static void Test(AbstractBaseClass ba)
        {
            ba.Output("Test");
        }

        static void Main(string[] args)
        {
            // You can't create an AbstractBaseClass object because it's
            // abstract. C# generates a compile-time error if you
            // uncomment the following line.
            // AbstractBaseClass ba = new AbstractBaseClass();

            Console.WriteLine("\ncreating a SubClass1 object");
            SubClass1 sc1 = new SubClass1();
            Test(sc1);

            Console.WriteLine("\ncreating a SubClass2 object");
            SubClass2 sc2 = new SubClass2();
            Test(sc2);

            Console.WriteLine("Press Enter to terminate... ");
            Console.Read();
        }
    }
}
