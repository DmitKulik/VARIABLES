using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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


            var User = EnterUser();
            Console.WriteLine($"\nВас зовут - {User._Name}\nВаша Фамилия - {User._SurName}\nВаш возраст - {User._Age}");
            try
            {
                Console.WriteLine("Ваших животных зовут: " + "{0}", string.Join("\n", User._PetsNames));
            }
            catch (Exception)
            {
                Console.WriteLine("Животинка отсутствует");
            }



            try
            {
                Console.WriteLine("Ваши цвета: " + "{0}", string.Join("\n", User._ColorNames));
            }
            catch (Exception)
            {
                Console.WriteLine("Вы очень серы в своем одиночестве!");
            }

        }
        static (string _Name, string _SurName, int _Age, string[] _PetsNames, string[] _ColorNames) EnterUser()
        {
            (string _Name, string _SurName, int _Age, string[] _PetsNames, string[] _ColorNames) InfoUser;

            Console.WriteLine("Ввод имени пользователя");
            InfoUser._Name = checked((string)(Console.ReadLine()));

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
            InfoUser._PetsNames = MethodPets();
            InfoUser._ColorNames = MethodColor();
            return InfoUser;
        }
        static string[] MethodPets()
        {
            Console.WriteLine("Есть ли у вас животные?\n\n     Да или Нет");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                string CountPet;
                int intCountPet;
                do
                {
                    Console.WriteLine("Сколько у вас животных?");
                    CountPet = Console.ReadLine();

                } while (CheckInt(CountPet, out intCountPet));

                string[] Pet = new string[intCountPet];

                for (int i = 0; i < intCountPet; i++)
                {
                    Console.WriteLine($"Ввод дом. животное № {i + 1}");
                    Pet[i] = Console.ReadLine();
                }
                return Pet;
            }
            else
            {
                return null;
            }
        }
        static string[] MethodColor()
        {
            Console.WriteLine("У вас есть любимый цвет?\n\n     Да или Нет");
            var resultColor = Console.ReadLine();
            if (resultColor == "Да")
            {
                string CountPet;
                int intCountPet;
                do
                {
                    Console.WriteLine("Сколько у вас цветов, которые вам нравятся?");
                    CountPet = Console.ReadLine();

                } while (CheckInt(CountPet, out intCountPet));

                string[] Pet = new string[intCountPet];

                for (int i = 0; i < intCountPet; i++)
                {
                    Console.WriteLine($"Ввод цвета № {i + 1}");
                    Pet[i] = Console.ReadLine();
                }
                return Pet;
            }
            else
            {
                return null;
            }
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
      
    }
}











