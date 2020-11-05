//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{
//    abstract class AbstractBase
//    {
//        protected void PrivateMethodA()
//        {
//            Console.WriteLine("AbstractBase.PrivateMethodA()");
//        }

//        public void PublicMethodA()
//        {
//            Console.WriteLine("AbstractBase.PublicMethodA()");
//        }

//        public abstract void AbstractMethodA();
//    }

//    class Derived : AbstractBase
//    {
//        public override void AbstractMethodA()
//        {
//            Console.WriteLine("Derived.AbstractMethodA()");
//            PrivateMethodA();
//        }
//    }

//    class AbstractClass
//    {
//        static void Main()
//        {
//            AbstractBase obj = new Derived();
//            obj.AbstractMethodA();
//            obj.PublicMethodA();
//        }
//    }
//}
