﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Global
//    {
//        public static int Count = 0;
//    }

//    class ClassA
//    {
//        public ClassA()
//        {
//            Global.Count++;
//        }
//    }
//class ClassB
//{
//        public ClassB()
//        {
//            Global.Count++;
//        }
//    }

//    class StaticField
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"Global.Count : {Global.Count}");

//            new ClassA();
//            new ClassA();
//            new ClassB();
//            new ClassB();

//            Console.WriteLine($"Global.Count : {Global.Count}");
//        }
//    }
//}
