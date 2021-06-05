using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Text
{
    class CheckText
    {
        /// <summary>
        /// Воспринимает на фход текст, разделяя его на массив слов, убирая знаки препинания и пробелы.
        /// Если массив пустой, возвращает null
        /// </summary>
        /// <param name="Text">Проверяемый текст</param>
        /// <returns>Массив слов, если текст не пустой или null</returns>
        public string[] NoNullText(string Text)
        {
            char[] charSeparators = new char[] { ' ', ',', '!', '?', '.', '/' }; // удаляемые символы
            string[] arrayWords = Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (arrayWords.Length > 0)
            {
                return arrayWords;
            }
            else
            {
                return null;
            }
        }
    }
}
