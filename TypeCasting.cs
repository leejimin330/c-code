//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Mammal
//    {
//        public void Nurse()
//        {
//            Console.WriteLine("Nurse()");
//        }
//    }

//    class Dog : Mammal
//    {
//        public void Bark()
//        {
//            Console.WriteLine("Bark()");
//        }
//    }

//    class Cat : Mammal
//    {
//        public void Meow()
//        {
//            Console.WriteLine("Meow");
//        }
//    }

//    class TypeCasting
//    {
//        static void Main(string[] args)
//        {
//            Mammal mammal1 = new Dog();
//            Dog dog;
//            if(mammal1 is Dog)
//            {
//                dog = (Dog)mammal1;
//                dog.Bark();
//            }

//            Mammal mammal2 = new Cat();

//            Cat cat = mammal2 as Cat;
//            if (cat != null)
//                cat.Meow();

//            Cat cat2 = mammal1 as Cat;
//            if (cat2 != null)
//                cat2.Meow();
//            else
//                Console.WriteLine("cat2 is not a Cat");
//        }
//    }
//}
