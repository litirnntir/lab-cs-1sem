using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__7
{
    class Function
    {
        /// <summary>
        /// Задание значений переменных
        /// </summary>
        /// <returns></returns>
        public static void Functions()
        {
            Console.WriteLine("Функция: F = sin(alpha^3 + beta^5/(2*pi)) + (cos(alpha + beta))^1/3");
            double alpha = Control.Alpha();
            double beta = Control.Beta();

            Console.Write("Введите переменную alpha: ");
            while (!double.TryParse(Console.ReadLine(), out alpha))
            {
                Console.WriteLine("Введите число");
            }
            Console.Write("Введите переменную beta: ");
            while (!double.TryParse(Console.ReadLine(), out beta))
            {
                Console.WriteLine("Введите число: ");
            }
            Console.WriteLine(Answer());
        }

        /// <summary>
        /// Подсчёт функции и ввод попыток пользователя
        /// </summary>
        /// <returns></returns>
        public static string Answer()
        {
            double alpha = Control.Alpha();
            double beta = Control.Beta();
            double function = Math.Sin((Math.Pow(alpha, 3) + Math.Pow(beta, 5)) / (2 * Math.PI)) + Math.Pow(Math.Cos(alpha + beta), 1.0 / 3.0);
            string s = "";
            int count = 0;
            function = Math.Round(function, 4);

            int quantry = 3;
            Console.WriteLine("У вас есть 3 попытки, чтобы отгадать значение функции");
            while (count < 3)
            {
                if (Control.Youranswer() == function)
                {
                    s = "Молодец! Твой ответ правильный! Ты выйграл!!!!!";
                    count = 4;
                }
                else
                {
                    count++;
                    quantry--;
                    Console.WriteLine("Осталось попыток: " + quantry);
                }
            }
            if (count == 3)
            {
                s = "Вы использовали все попытки. Вы проиграли! Правильный ответ: " + function;
            }
            return s;
        }
    }
}
