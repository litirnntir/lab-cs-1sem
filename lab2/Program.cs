using System;

namespace lab
{
    class Program
    {
        static double CorrectAnswer(double a, double b) // объявление метода: правильный ответ
        {
            // объявления переменных
            double f;
            double pi = Math.PI;
            double sin = Math.Sin((Math.Pow(a, 3) + Math.Pow(b, 5)) / (2 * pi));
            double cos = Math.Cos(a + b);

            if (cos < 0)
            {
                f = sin - Math.Pow(Math.Abs(cos), 1.0 / 3.0);
            }

            else
            {
                f = sin + Math.Pow(cos, 1.0 / 3.0);
            }
            return f;
        }

        static double Ask() // объявление нового метода: вопрос пользователю
        {
            Console.WriteLine("Чему равно значение функции: sin((a^3 + b^5)/2pi)+(cos(a+b))^(1/3)?");
            double answer;
            while (!double.TryParse(Console.ReadLine(), out answer))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            return answer;
        }

        static void PrintAnswer(double f, double answer) // объявление нового метода: проверка ответа
        {
            Console.WriteLine("Правильное значение функции: " + f);
            if (f != answer)
            {
                if (Math.Round(f, 2) == answer) // проверка правильности округленного ответа
                {
                    Console.WriteLine("\nВаш ответ верен!\n\nНажмите для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nВаш ответ неверен!\n\nНажмите для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("\nВаш ответ полностью верен!\n\nНажмите для продолжения!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void TryToGuess() // объявление нового метода: игра
        {
            Console.Clear();
            Console.WriteLine("Введите значения параметров функции: "); // ярлык ввода значений
            Console.Write("a = ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            Console.Write("b = ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            double f = CorrectAnswer(a, b);
            double answer = Ask();
            PrintAnswer(f, answer);
        }

        static void Main(string[] args)
        {

            bool exit = false;
            char exitchoose;
            int menu;

            do
            {
                Console.WriteLine("Лабораторная работа 2. Меню действий:\n1 – Отгадай ответ\n2 – Об авторе\n3 – Выход");

                while (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.Write("Неверный формат!\nВведите число: ");
                }
                switch (menu)
                {
                    case 1:
                        TryToGuess();
                        Console.Clear();
                        continue;
                    case 2:
                        Console.WriteLine("Горбунцова А.А. 6101-090301D\nНажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 3:
                        Console.WriteLine("Вы действительно хотите выйти?\nд - Да\nн - Нет");
                        while (!char.TryParse(Console.ReadLine(), out exitchoose))
                        {
                            Console.Write("Неверный формат!\nВведите число: ");
                        }
                        Console.Clear();

                        if (exitchoose == 'д' || exitchoose == 'Д' || exitchoose == 'l' || exitchoose == 'L')
                        {
                            exit = true;
                        }
                        else if (exitchoose == 'н' || exitchoose == 'Н' || exitchoose == 'y' || exitchoose == 'Y')
                        {
                            Console.WriteLine("Нажмите для возврата к главному меню");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат значения\n\nНажмите для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный формат значения\n\nНажмите для возврата в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (exit == false);

        }
    }
}