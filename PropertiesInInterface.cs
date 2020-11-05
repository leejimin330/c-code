//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{
//    interface INameValue
//    {
//        string Name
//        {
//            get; set;
//        }

//        string Value
//        {
//            get; set;
//        }
//    }

//    class NamedValue : INameValue
//    {
//        public string Name
//        {
//            get; set;
//        }
//        public string Value
//        {
//            get; set;
//        }
//    }

//    class PropertiesInInterface
//    {
//        static void Main(string[] args)
//        {
//            NamedValue name = new NamedValue()
//            { Name = "이름", Value = "박상현" };

//            NamedValue height = new NamedValue()
//            { Name = "키", Value = "177cm" };

//            NamedValue weight = new NamedValue()
//            { Name = "몸무게", Value = "90kg" };

//            Console.WriteLine($"{name.Name} : {name.Value}");
//            Console.WriteLine($"{height.Name} : {height.Value}");
//            Console.WriteLine($"{weight.Name} : {weight.Value}");
//        }
//    }
//}
