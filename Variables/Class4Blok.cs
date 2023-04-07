using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VariableS {
    public class Class4Blok {


        public void Blok(){

            //Задание 4.1.4
            string A = "dom";
            string B = "dip";
            bool C = A != B;

            //Задание 4.1.5

            int AA = 1;
            int BB = 0;
            double XX = 44;
            double YY = 3;
            bool CC = (AA < BB) | (XX > YY);


            //Задание 4.1.10
            var inv = true;
            var result = !inv;

            //Console.WriteLine("result = {0}", result);
            //Console.ReadKey();

            var a = 6;
            var b = 7;

            var color = Console.ReadLine();

            if (color == "red") {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green") {

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }


        }




    }
}
