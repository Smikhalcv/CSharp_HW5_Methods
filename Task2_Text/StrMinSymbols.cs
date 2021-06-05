using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Text
{
    class StrMinSymbols
    {
        /// <summary>
        /// Воспринимает на вход текст и выводит самое короткое слово.
        /// </summary>
        /// <param name="Text">Проверяемый текст</param>
        /// <returns>Первое встречаемое в тексте слово, состоящее из минимального количества символов</returns>
        public static string MinSymbols(string Text)
        {
            // Вызывает проверку текста и разбиение его на слова
            CheckText arrayText = new CheckText();
            string[] arrayWords = arrayText.NoNullText(Text);
            string nullAnswer = "Текст пустой!";
            // Если текст не пустой выбирает первое слово состоящее из минимального кличества символов
            if (arrayWords != null)
            {
                int countSymb = arrayWords[0].Length;
                string resultStr = arrayWords[0];
                for (int i = 1; i < arrayWords.Length; i++)
                {
                    if (arrayWords[i].Length < countSymb)
                    {
                        countSymb = arrayWords[i].Length;
                        resultStr = arrayWords[i];
                    }
                }
                return resultStr;
            }
            else
            {
                return nullAnswer;
            }

        }


    }
}
