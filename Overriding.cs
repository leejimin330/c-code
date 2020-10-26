//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class ArmorSuite
//    {
//        public virtual void Initialize()
//        {
//            Console.WriteLine("Armored");
//        }
//    }

//    class IronMan : ArmorSuite
//    {
//        public override void Initialize()
//        {
//            base.Initialize();
//            Console.WriteLine("Repulsor Rays Armed");
//        }
//    }

//    class Warmachine : ArmorSuite
//    {
//        public override void Initialize()
//        {
//            base.Initialize();
//            Console.WriteLine("Double-Barrel Cannons Armed");
//            Console.WriteLine("Micro_Rocket Launcher Armed");
//        }

//    }

//    class Overriding
//    {
//        static void Main(string args[])
//        {
//            Console.WriteLine("Creating ArmorSuite...");
//            ArmorSuite armorsuite = new ArmorSuite();
//            armorsuite.Initialize();

//            Console.WriteLine("\n Creating IronMan");
//            ArmorSuite ironman = new IronMan();
//            ironman.Initialize();
//        }
//    }
//}
