using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableS{
    internal class Program{
        static void Main(){

            string _myName = "Dima";
            int _age = 10; //лучше byte
            bool _pet = true;
            double _size = 39.5;


            Console.WriteLine($"My name is {_myName}");
            Console.WriteLine($"My age is {_age}");
            Console.WriteLine($"Do i have a Pet? {_pet}");
            Console.WriteLine($"My shoe size is {_size}");

            Console.WriteLine("floatMin {0} ", float.MinValue);
            Console.WriteLine("floatMax {0} ", float.MaxValue);

            Console.ReadKey();
        }

    }
}
