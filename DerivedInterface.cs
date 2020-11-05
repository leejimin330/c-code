﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{
//    interface ILogger
//    {
//        void WriteLog(string message);
//    }

//    interface IFormattableLogger : ILogger
//    {
//        void WriteLog(string format, params Object[] args);
//    }

//    class ConsoleLogger2 : IFormattableLogger
//    {
//        public void WriteLog(string message)
//        {
//            Console.WriteLine("{0} , {1}", DateTime.Now.ToLocalTime(),message);
//        }

//        public void WriteLog(string format, params Object[] args)
//        {
//            String message = String.Format(format, args);
//            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
//        }
//    }

//    class DerivedInterface
//    {
//        static void Main(string[] args)
//        {
//            IFormattableLogger logger = new ConsoleLogger2();
//            logger.WriteLog("the world is flat");
//            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
//        }

//    }
//}
