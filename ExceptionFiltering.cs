﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{
//    class FilterableException : Exception
//    {
//        public int ErrorNo { get; set; }
//    }

//    class ExceptionFiltering
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Number Between 0 ~ 10");
//            string Input = Console.ReadLine();
//            try
//            {
//                int num = Int32.Parse(Input);

//                if (num < 0 || num > 10)
//                    throw new FilterableException() { ErrorNo = num };
//                else
//                    Console.WriteLine($"Output : {num}");
//            }
//            catch(FilterableException e) when (e.ErrorNo < 0)
//            {
//                Console.WriteLine("Negative Input is not allowed");
//            }
//            catch(FilterableException e) when (e.ErrorNo > 10)
//            {
//                Console.WriteLine("Too big number is not allowed");
//            }
//        }
//    }
//}
