﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VariableS;

namespace VariableS
{
    class Program
    {

        static void Main(string[] args)
        {

            /*Tuples TupJob = new Tuples();
            TupJob.Tup();
            Array blok = new Array();
            blok.Blok();
            Methods methods = new Methods();
            //methods.GetName();
            //methods.ShowColor();
            //var array = methods.GetArrayFromConsole();*/


            static (string _Name, string _SurName, int _Age) AddUser()
            {

                (string _Name, string _SurName, int _Age) InfoUser;
                Console.WriteLine("Ввод имени пользователя");
                InfoUser._Name = Console.ReadLine();
                Console.WriteLine("Ввод фамилии пользователя");
                InfoUser._SurName = Console.ReadLine();
                string _Age;
                int _IntAge;

                do
                {
                    Console.WriteLine("Ввод возраста цифрами");
                    _Age = Console.ReadLine();

                } while (CheckInt(_Age, out _IntAge));

                InfoUser._Age = _IntAge;
                return InfoUser;

            }
            static bool CheckInt(string Num, out int _CorrectN)
            {
                if (int.TryParse(Num, out int _IntAge))
                {

                    if (_IntAge > 0)
                    {
                        _CorrectN = _IntAge;
                        return false;
                    }
                }
                {
                    _CorrectN = 0;
                    return true;
                }

            }
            Console.ReadKey();

            /*string _myName = "Dima";
            int _age = 10; //лучше byte
            bool _pet = true;
            double _size = 39.5;
            string _favcolor = "Green";
            */

            // Console.WriteLine("Прочитать строку");
            //string _str = Console.ReadLine();

            //Финальная практика модуля «Анкетируем пользователей»
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("You favorite day of week: ");
            var day = (Week) int.Parse(Console.ReadLine());
            Console.Write("Enter your birthdate: ");
            var birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} Age is {1} Favorite day is {2} and birthdate {3}", name, age, day, birthdate);
            Console.ReadKey();*/


            // Console.WriteLine("Имя {0},\nВозраст {1}\nЛюбимый цвет {2}", _myName, _age, _favcolor);

            /*Console.WriteLine($"My name is {_myName}");
            Console.WriteLine($"Мой возраст {_age}");
            Console.WriteLine($"Do i have a Pet? {_pet}");
            Console.WriteLine($"My shoe size is {_size}");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("floatMin {0} ", float.MinValue);
            Console.WriteLine("floatMax {0} ", float.MaxValue);
            */


            // double result3 = 10 % 3;
            //Console.WriteLine(result3);

            // Console.ReadKey();

            /* int someAge = 33;
             Console.WriteLine(someAge);
             ChangeAge(someAge);
             Console.WriteLine(someAge);
             Console.ReadKey();*/


            //Задание 5.3.3
            //Добавьте слово ref в метод ChangeName перед именем параметра. Обратите внимание, что это слово нужно указать и в вызове метода.
            /*var someName = "Artem";
            Console.WriteLine(someName);
            GetName(ref someName);
            Console.WriteLine(someName);
            Console.ReadKey();*/





            /*var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
            Console.ReadKey();*/

            /*Console.WriteLine("Напишите что то");

            var str = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());
            Echo(str, deep);

            Console.ReadKey();*/





        }

        /* static void Echo(string saidworld, int deep)
         {
             //Console.WriteLine(phrase);
             var modif = saidworld;
             if (modif.Length > 2)
             {
                 modif = modif.Remove(0, 2);
                 var p = modif.Length;
             }
             Console.BackgroundColor = (ConsoleColor)deep;
             Console.WriteLine("..." + modif);

             if (deep > 1)
             {
                 Echo(modif, deep - 1);
             }

         }*/
        //Задание 5.5.8
        //Необходимо написать рекурсивный метод, который возводит введенное число N типа int в указанную степень pow типа byte

        /*private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {

                if (pow == 1)
                {
                    return N;

                }
                else
                {
                    return N * PowerUp(N, --pow);

                }
            }
            
        }*/


    }
}






