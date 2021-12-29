using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__7
{
    class String
    {
        private string _text;
        private string _st;
        public String()
        {
            _text = " Вот 1(иль единица),\n Очень тонкая, как спица,\n А вот это цифра 2.\n Полюбуйся, какова:\n Выгибает двойка шею,\n Волочится хвост за нею. \n А за двойкой – посмотри – Выступает цифра 3.\n Тройка – третий из значков –\n Состоит из двух крючков."; ;
        }
        public String(string st)
        {
            _st = st;
        }


        /// <summary>
        /// Подсчёт и вывод количества цифр
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        static int SumNum(string st)
        {
            char[] Cnt = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int h = 0;
            for (int i = 0; i < st.Length; i++)
                for (int j = 0; j < 9; j++)
                    if (st[i] == Cnt[j])
                        h++;
            return h;
        }

        public static void PrintSumNum(string _text)
        {
            Console.WriteLine("Количество цифр: " + SumNum(_text));
        }


        /// <summary>
        /// Выбор способа задания текста
        /// </summary>
        /// <returns></returns>
        public void Text()
        {
            switch (Control.Str_menu())
            {
                case 1:
                    Console.WriteLine("Вот 1 (иль единица),\n Очень тонкая, как спица,\n А вот это цифра 2.\n Полюбуйся, какова:\n Выгибает двойка шею,\n Волочится хвост за нею. \n А за двойкой – посмотри – Выступает цифра 3.\n Тройка – третий из значков – \n Состоит из двух крючков.");
                    Console.WriteLine("Количество цифр: " + SumNum(_text));
                    //SumNum(DefStr());
                    break;
                case 2:
                    Console.WriteLine("Введите текст");
                    _st = Console.ReadLine();
                    Console.WriteLine("Количество цифр: " + SumNum(_st));
                    break;
            }
            //string DefStr()
            //{
            //    text = "Исходная строка: \n Вот 1 (иль единица),\n Очень тонкая, как спица,\n А вот это цифра 2.\n Полюбуйся, какова:\n Выгибает двойка шею,\n Волочится хвост за нею. \n А за двойкой – посмотри – Выступает цифра 3.\n Тройка – третий из значков – \n Состоит из двух крючков.";
            //    return text;
            //}
            //return text;
        }
    }
}