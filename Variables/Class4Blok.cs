using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

            /*  if (color == "red") {

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
            */
            /*
              switch (color) { //Задание Задание 4.1.17

                  case "red":
                      Console.BackgroundColor = ConsoleColor.Red;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Your color is red!");
                      break;

                  case "green":
                      Console.BackgroundColor = ConsoleColor.Green;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Your color is green!");
                      break;

                  case "cyan":
                      Console.BackgroundColor = ConsoleColor.Cyan;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Your color is Cyan!");
                      break;

                  default:
                      Console.BackgroundColor = ConsoleColor.Yellow;
                      Console.ForegroundColor = ConsoleColor.Red;

                      Console.WriteLine("Your color is Yellow!");
                      break;
                      
        }
            string [] colors ={ "Yellow", "Green", "Red", "Blue", "Cyan" };
            var color2 = 0;

            do {
                if (color == "Yellow") {

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                     
                    Console.WriteLine(colors[color2]);
                    Console.WriteLine(color2 = color2 + 1);
               }


            } while (colors[color2] != "Red");
            


            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }

            Console.WriteLine("Цикл while");
            int k = 0;

            while (k < 3)  {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                        

                }
                k++;
            }
            Console.WriteLine("Введите свое имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            for (var y = name.Length - 1; y >= 0; y--) {
                Console.Write(name[y] + " ");// тут важно указать имя массива иначе возьмет индексы
                
            }
            //Console.WriteLine("Первая буква вашего имени: {0}", name[0]);
            Console.ReadKey();
            */

          
            int[,] name = { { 1, 2, 3 }, { 5, 6, 7 } };

            for (int i = 0; i < name.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < name.GetUpperBound(1) + 1; k++)
                    Console.Write(name[i, k] + " ");

                Console.WriteLine();
            }// тут важно указать имя массива иначе возьмет индексы

            //Console.WriteLine("Первая буква вашего имени: {0}", name[0]);
            Console.ReadKey();
        }

    }
}
