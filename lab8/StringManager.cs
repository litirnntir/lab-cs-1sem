using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_8
{
    class StringManager
    {
        /// <summary>
        /// Подсчёт и вывод количества цифр
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        static public int SumNum(string st)
        {
            char[] Cnt = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int h = 0;
            for (int i = 0; i < st.Length; i++)
                for (int j = 0; j <= 9; j++)
                    if (st[i] == Cnt[j])
                        h++;
            return h;
        }


        /// <summary>
        /// Выбор способа задания текста
        /// </summary>
        /// <returns></returns>
    }
}