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
    public class Methods
    {


        /*      public string ShowColor()
              {

                  //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                  var color = Console.ReadLine();

                  switch (color)
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
                          Console.ForegroundColor = ConsoleColor.Red;

                          Console.WriteLine("Your color is yellow!");
                          break;

                  }

                  return color;
      */


        /*//Модуль 5. Методы в C#           1 / 9  Введение

        (string user, string[] dish) UserFood;
        Console.WriteLine("Введите пользователя: ");
        UserFood.user = Console.ReadLine();
        UserFood.dish = new string[5];
        for (int i = 0; i < UserFood.dish.Length; i++)
        {
            Console.WriteLine("Введите любимое блюдо {0}: ", i + 1); // нумерация сообщения ({0}: ", i + 1)

            UserFood.dish[i] = Console.ReadLine(); //запись в массив в нутри картежа
        }
        Console.ReadKey();



        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        ShowColor();

        //Задание 5.1.5
        // Напишите программу, которая в цикле вызывает метод ShowColor(),
        // записывает его значение в массив из трех цветов favcolors, а потом отображает значения этого массива

        var favcolor = new string[3];
        for (int i = 0; i < favcolor.Length; i++)
        {
            favcolor[i] = ShowColor();

        }
        Console.WriteLine("Введите ваш цвет:");
        foreach (var color1 in favcolor)
        {
            Console.WriteLine(color1);
        }

        Console.ReadKey();


    }*/


        /*        public void Method2()
                {

                    //Задание 5.1.6
                    //Модифицируйте метод из скринкаста:  после ввода массива с клавиатуры необходимо отсортировать массив и вывести его на экран.

                    {
                        GetArrayFromConsole();
                    }

                    int[] GetArrayFromConsole()

                    {
                        var result = new int[5];

                        for (int i = 0; i < result.Length; i++)
                        {
                            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                            result[i] = int.Parse(Console.ReadLine());

                        }
                        int temp = 0;
                        for (int i = 0; i < result.Length; i++) { 

                            for (int h = i + 1; h < result.Length; h++)
                            {
                                if (result[i] > result[h])
                                {
                                    temp = result[i];
                                    result[i] = result[h];
                                    result[h] = temp;
                                }

                            }
                        }

                        Console.WriteLine("Вывод массива");

                        for (int i = 0; i < result.Length; i++)
                        {
                            Console.WriteLine(result[i]);
                        }

                        Console.ReadKey();

                        return result;

                    }
                }*/



        //Задание 5.1.6
        //Модифицируйте метод из скринкаста:  после ввода массива с клавиатуры необходимо отсортировать массив и вывести его на экран.


        //адание 5.2.8
        // Разделить метод из задания 5.1.6 GetArrayFromConsole() на два: один метод GetArrayFromConsole() должен читать введенные с клавиатуры массивы и возвращать их, второй метод SortArray() должен принимать параметром массив array типа данных int, сортировать его и возвращать.





        public int[] GetArrayFromConsole() //метод заполнения массива

        {
            var result = new int[3];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());

            }

            return result;

        }

        public int[] SortArray(int[] result) //метод сортировки массива
        {



            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {

                for (int h = i + 1; h < result.Length; h++)
                {
                    if (result[i] > result[h])
                    {
                        temp = result[i];
                        result[i] = result[h];
                        result[h] = temp;
                    }

                }
            }

            return result;
        }
        
        public void ShowArray(int[] array, bool isSort = false)//метод вывода массива на экран с сортировкой

        {
            var temp = array;
            if (isSort)
            {
                temp = SortArray(array);
            }
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
    

}





