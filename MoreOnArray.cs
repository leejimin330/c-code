﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{
//    class MoreOnArray
//    {
//        private static bool CheckPassed(int score)
//        {
//            if (score >= 60)
//                return true;
//            else
//                return false;
//        }

//        private static void Print(int Value)
//        {
//            Console.WriteLine($"{Value}");
//        }

//        static void Main(string[] args)
//        {
//            int[] scores = new int[] { 80, 74, 90, 34 };

//            foreach (int score in scores)
//                Console.WriteLine($"score");
//            Console.WriteLine();

//            Array.Sort(scores);
//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            Console.WriteLine($"Number of dimensiions : {scores.Rank}");

//            Console.WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch<int>(scores, 81));
//            Console.WriteLine("Liner Search : 90 is at {0}", Array.IndexOf(scores, 90));


//            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

//            int index = Array.FindIndex<int>(scores,
//                delegate (int score)
//                {
//                    if (score < 60)
//                        return true;
//                    else return false;
//                });

//            scores[index] = 61;

//            Console.WriteLine("Everyone Passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

//            Console.WriteLine($"Old legth of scores : {scores.GetLength(0)}");

//            Array.Resize<int>(ref scores, 10);

//            Console.WriteLine($"New length of scores : {scores.GetLength(0)}");

//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            Array.Clear(scores, 3, 7);

//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();
//        }
//    }
//}
