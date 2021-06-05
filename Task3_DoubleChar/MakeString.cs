using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_DoubleChar
{
    class MakeString
    {
        /// <summary>
        /// Воспринимает на вход строку и возвращает новую, без дублированных символов
        /// </summary>
        /// <param name="Text">Текст с дублированными символами</param>
        public string ThinString(string Text)
        {
            string result = Text[0].ToString();
            string text = Text.ToLower();
            for (int i = 1; i < Text.Length; i++)
            {
                if (text[i - 1] != text[i])
                {
                    result += Text[i];
                }
            }
            return result;
        }
    }
}
