using System;

namespace Лабораторная_работа__7
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            char exit = 'н';
            while (exit != 'д')
            {
                Console.WriteLine(" 1 - Отгадай ответ\n 2 - Об авторе\n 3 - Сортировка\n 4 - Игра\n 5 - Обработка строк\n 6 - Выход ");
                int number;
                int.TryParse(Console.ReadLine(), out number);
                Console.Clear();
                switch (number)
                {
                    case 1:

                        Console.WriteLine(Function.Answer());
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Горбунцова А.А\nгруппа 6101-090301D");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Array Arr = new Array();
                        Arr.Element();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Шахматы");
                        Game game = new Game();
                        game.Chess();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        String str = new String();
                        str.Text();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine("Выйти из программы? д-да / н-нет ");
                        exit = char.Parse(Console.ReadLine());
                        if (exit == 'д')
                            Environment.Exit(0);
                        else
                            if (exit == 'н')
                            Console.Clear();
                        else
                            Console.WriteLine("Значение введено неверно, повторите попытку");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Ошибка!\n Выбранное значение введено неверно, повторите ввод");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}