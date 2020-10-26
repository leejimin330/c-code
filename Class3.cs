//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Class3
//    {
//        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }

//        static void Main(string[] args)
//        {
//            const int MAX_INT = 2147483647;
//            const int MIN_INT = -2147483648;

//            Console.WriteLine(MAX_INT);
//            Console.WriteLine(MIN_INT);

//            Console.WriteLine((int)DialogResult.YES);
//            Console.WriteLine((int)DialogResult.NO);
//            Console.WriteLine((int)DialogResult.CANCEL);
//            Console.WriteLine((int)DialogResult.CONFIRM);
//            Console.WriteLine((int)DialogResult.OK);

//            DialogResult result = DialogResult.YES;

//            Console.WriteLine(result == DialogResult.YES);
//            Console.WriteLine(result == DialogResult.NO);
//            Console.WriteLine(result == DialogResult.CANCEL);
//            Console.WriteLine(result == DialogResult.CONFIRM);
//            Console.WriteLine(result == DialogResult.OK);

//            Console.WriteLine();

//            int? a = null;

//            Console.WriteLine(a.HasValue);
//            Console.WriteLine(a != null);

//            a = 3;

//            Console.WriteLine(a.HasValue);
//            Console.WriteLine(a != null);
//            Console.WriteLine(a.Value);
//        }
//    }
//}
