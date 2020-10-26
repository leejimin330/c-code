//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Base
//    {
//        public void MyMethod()
//        {
//            Console.WriteLine("Base.MyMethod()");
//        }
//    }

//    class Derived : Base
//    {
//        public new void MyMethod()
//        {
//            Console.WriteLine("Derived.MyMethod");
//        }
//    }

//    class MethodHiding
//    {
//        static void Main(string[] args)
//        {
//            Base baseObj = new Base();
//            baseObj.MyMethod();

//            Derived deriveObj = new Derived();
//            deriveObj.MyMethod();

//            Base BaseOrDerived = new Derived();
//            BaseOrDerived.MyMethod();

//        }
//    }
//}
