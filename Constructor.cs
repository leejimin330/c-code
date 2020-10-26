//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Cat
//    {
//        public Cat()
//        {
//            Name = "";
//            Color = "";
//        }
//        public Cat(string _Name, string _Color)
//        {
//            Name = _Name;
//            Color = _Color;
//        }

//        ~Cat()
//        {
//            Console.WriteLine($"{Name} : 잘가");
//        }

//        public string Name;
//        public string Color;

//        public void Meow()
//        {
//            Console.WriteLine($"{Name} : 냐옹");
//        }

//    }
//    class Constructor
//    {
//        static void Main(string[] args)
//        {
//            Cat kitty = new Cat("키티", "하얀색");
//            kitty.Meow();
//            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

//            Cat nero = new Cat("네로", "검은색");
//            nero.Meow();
//            Console.WriteLine($"{nero.Name} : {nero.Color}");
//        }
//    }
//}
