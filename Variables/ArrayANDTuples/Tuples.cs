using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using VariableS;

namespace VariableS
{
    public class Tuples
    {

        public void Tup()
        {

            //Задание 4.4.2
            //Модифицируйте свою программу для ввода личной информации пользователя так, чтобы данные записывались в кортеж anketa

            /*
            (string name, byte age, Enum day, DateTime birthdate) anketa;

            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();
            Console.Write("Enter your age: ");
            anketa.age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("You favorite day of week: ");
            anketa.day = ((Week)int.Parse(Console.ReadLine()));
            Console.Write("Enter your birthdate: ");
            anketa.birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} Age is {1} Favorite day is {2} and birthdate {3}", anketa.name, anketa.age, anketa.day, anketa.birthdate);
            Console.ReadKey();
            


            //Задание 4.4.3

            var (name, age) = ("Dima", 27);
            Console.WriteLine("You name : {0}", name);
            Console.WriteLine("You age : {0}", age);
            Console.WriteLine("Ввеlите имя : ");
            name = Console.ReadLine();
            Console.WriteLine("Ввеlите возраст : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You name : {0}", name);
            Console.WriteLine("You age : {0}", age);
            Console.ReadKey();
            

            //Задание 4.4.4
            //var Pet1 = (name : (Console.ReadLine()), type: (Console.ReadLine()), age : checked((byte)int.Parse(Console.ReadLine())));
            //(string Name, string Type, byte Age) Pet;

            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возрас питомца");
            Pet.Age = double.Parse(Console.ReadLine());
            

            //Заданиz 4.5.1  4.5.2  4.5.3   4.5.4   4.5.5
            // Необходимо разработать методику анкетирования пользователей. 
            //Требуется сохранять информацию: об имени пользователя, фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.

            (string Name, string SurName, string UserLogin, int LoginLength, bool HasPet, double Age, string[] UserColor) Anketa; //4.5.1
            for (int p = 0; p < 3; p++)
            {

                Console.WriteLine("Введите имя: "); //4.5.2
                Anketa.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                Anketa.SurName = Console.ReadLine();
                Console.WriteLine("Введите логин: ");
                Anketa.UserLogin = Console.ReadLine();

                Anketa.LoginLength = Anketa.UserLogin.Length; //4.5.3

                Console.WriteLine("Есть ли у вас животные? Да или Нет");//4.5.4
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    Anketa.HasPet = true;
                }
                else
                {
                    Anketa.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");//4.5.5
                Anketa.Age = double.Parse(Console.ReadLine());
                Anketa.UserColor = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < Anketa.UserColor.Length; i++)
                {
                    Anketa.UserColor[i] = Console.ReadLine();
                }
                Console.WriteLine("Ваше Имя {0} Ваша Фамилия {1} Ваш Логин {2} Длина Логина {3} У вас есть животное? {4} Ваш возраст {5} Ваши цвета {6}", Anketa.Name, Anketa.SurName, Anketa.UserLogin, Anketa.LoginLength, Anketa.HasPet, Anketa.Age, Anketa.UserColor);
                Console.ReadKey();

                */
        }






    }

    

}
































