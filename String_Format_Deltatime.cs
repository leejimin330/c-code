//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System.Globalization;
//using static System.Console;


//namespace ConsoleApp7
//{
//    class String_Format_Deltatime
//    {
//        static void Main(string[] args)
//        {
//            DateTime dt = new DateTime(2020, 9, 22, 19, 54, 33);

//            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
//            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

//            CultureInfo ciKo = new CultureInfo("ko-KR");
//            WriteLine();
//            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
//            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
//            WriteLine(dt.ToString(ciKo));

//            CultureInfo ciEn = new CultureInfo("en-US");
//            WriteLine();
//            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
//            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
//            WriteLine(dt.ToString(ciKo));
//        }
//    }
//}
