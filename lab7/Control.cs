using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__7
{
    class Control
    {
        /// <summary>
        /// Проверка корректности ввода переменной выбора пункта меню
        /// </summary>
        /// <returns></returns>
        public static int Menu()
        {
            int menu;
            do
            {
                Console.WriteLine("Выберите, какая фигура должна быть показана:\n1 - Ладья\n2 - Слон\n3 - Конь");
            } while (!int.TryParse(Console.ReadLine(), out menu));
            return menu;
        }

        /// <summary>
        /// Проверка корректности ввода переменной выбора пункта меню
        /// </summary>
        /// <returns></returns>
        public static int Str_menu()
        {
            int str_menu;
            do
            {
                Console.WriteLine("Выберите, где будет происходить подсчёт:\n1 - Исходный текст\n2 - Заданные строки");
            } while (!int.TryParse(Console.ReadLine(), out str_menu) & ((str_menu != 1) | (str_menu != 2)));
            return str_menu;
        }

        /// <summary>
        /// Проверка корректности ввода переменной а
        /// </summary>
        /// <returns></returns>
        public static double Alpha()
        {
            double alpha;
            do
            {
                Console.WriteLine("Введите значение alpha:");
            } while (!double.TryParse(Console.ReadLine(), out alpha));
            return alpha;
        }

        /// <summary>
        /// Проверка корректности ввода переменной b
        /// </summary>
        /// <returns></returns>
        public static double Beta()
        {
            double beta;
            do
            {
                Console.WriteLine("Введите значение beta:");
            } while (!double.TryParse(Console.ReadLine(), out beta));
            return beta;
        }

        /// <summary>
        /// Проверка корректности ввода значения функции
        /// </summary>
        /// <returns></returns>
        public static double Youranswer()
        {
            double youranswer;
            do
            {
                Console.WriteLine("Чему равно значение функции F = sin(alpha^3 + beta^5/(2*pi)) + (cos(alpha + beta))^1/3");
            }
            while (!double.TryParse(Console.ReadLine(), out youranswer));
            {
                Console.WriteLine("Введите число, пожалуйста: ");
            }
            youranswer = Math.Round(youranswer, 4);
            return youranswer;
        }

        /// <summary>
        /// Проверка корректности ввода пункта меню
        /// </summary>
        /// <returns></returns>
        public static int K()
        {
            int k;
            do
            {
                k = int.Parse(Console.ReadLine());
            } while (k != 1 & k != 2);
            return k;
        }

        /// <summary>
        /// Проверка корректности ввода количества элементов массива
        /// </summary>
        /// <returns></returns>
        public static int N()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) | (n <= 0))
            {
                Console.WriteLine("Введите количество элементов массива");
            }
            return n;
        }

    }
}