//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Switch2
//    {
//        static void Main()
//        {
//            object obj;

//            string s = Console.ReadLine();
//            if (int.TryParse(s, out int out_i))//코드의 흐름을 끊지 않는 tryparse 문
//                obj = out_i;
//            else if (float.TryParse(s, out float out_f))
//                obj = out_f;
//            else
//                obj = s;
//            switch (obj)
//            {
//                case int i:
//                    Console.WriteLine($"{i}는 int 혈식입니다.");
//                    break;
//                case float f when f > 0:
//                    Console.WriteLine($"{f}는 양의 float 형식입니다.");
//                    break;
//                case float f:
//                    Console.WriteLine($"{f}는 float 형식입니다.");
//                    break;
//                default:
//                    Console.Write($"{obj}는 모르는 형식입니다.");
//                    break;
//            }
//        }
//    }
//}
