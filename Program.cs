using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        /* static void Hellow() Задача 1. Вывод  сообщений приветствия и прощания с использованием дополнительных методов.
         {
             Console.WriteLine("Вывод в первом методе: Привет");
         }
         static void Parting()
         {
             Console.WriteLine("Вывод во втором методе: Пока");
         }
         static void Main (string[] args)
         { 
             Hellow();
             Parting();
             Console.ReadLine();
         }*/


        /*static int number1; //Задача 2. Нахождение суммы, разности, произведения и частного двух целых чисел с использованием дополнительных методов.
        static int number2; 
        static void Sum() 
        {
            Console.WriteLine($"Сумма чисел {number1} и {number2} = {number1 + number2}");
        }

        static void difference()
        {
            Console.WriteLine($"Разность числе {number1} и {number2} = {number1 + number2}");

        }

        static void Work()
        {
            Console.WriteLine($"Произведение чисел {number1} и {number2} = {number1 + number2}");

        }

        static void Private()
        {
            if (number2 != 0)
            {
                Console.WriteLine($"Частное чисел {number1} и {number2} = {number1 / (double)number2}");
            }
            else
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            
        }

        public static void Write()
        {
            Console.Write("Введите первое число: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
        }
        static void Main(string[] args)
        {   
            Write();
            Sum();
            difference();
            Work();
            Private();

            Console.ReadLine();
            

        }*/
        //Задача 3. Вычисление значения функции:
        /*public static double Example(double x)
        {
            if (x < 5)
            {
                return (4 * x * x + 1) / (x - 5);
            }
            else if (x >= 5)
            {
                return 3 * x * x - 2;
            }
            else
            {
                return double.NaN;
            }
        }

        public static void Main()
        {
            bool Checking = false;
            double x;

            while (!Checking)
            {
                Console.Write("Введите значение x: ");
                if (double.TryParse(Console.ReadLine(), out x))
                {

                    Checking = true;
                    double result = Example(x);
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
            Console.ReadKey();
        }*/
    }





}

