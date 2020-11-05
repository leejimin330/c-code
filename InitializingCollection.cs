//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//using static System.Console;

//namespace ConsoleApp8
//{
//    class InitializingCollection
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 123, 456, 789 };
            
//            ArrayList list = new ArrayList(arr);
//            foreach (object item in list)
//                WriteLine($"ArrayList  : {item}");
//            WriteLine();

//            Stack stack = new Stack(arr);
//            foreach (object item in stack)
//                WriteLine($"Stack : {item}");
//            WriteLine();

//            Queue que = new Queue(arr);
//            foreach (object item in que)
//                WriteLine($"Queue : {item}");
//            WriteLine();

//            ArrayList list2 = new ArrayList() { 11, 22, 33 };
//            foreach (object item in list2)
//                WriteLine($"ArrayList2 : {item}");
//            WriteLine();
//        }
//    }
//}
