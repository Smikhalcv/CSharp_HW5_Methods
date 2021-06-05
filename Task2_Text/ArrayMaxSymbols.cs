using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Text
{
    class ArrayMaxSymbols
    {
        /// <summary>
        /// Принимает на вход текст и выводит массив слов с максимальным количеством символов.
        /// </summary>
        /// <param name="Text">Проверяемый текст</param>
        /// <returns>Массив со словами имеющими максимальное количество символов</returns>
        public static string[] MaxSymbols(string Text)
        {
            string[] nullAnswer = { "Текст пустой!" };
            CheckText arrayText = new CheckText();
            string[] arrayWords = arrayText.NoNullText(Text);
            int[] counterSymbols = new int[] {0, 0};
            if (arrayWords != null)
            {
                foreach (string word in arrayWords)
                {
                    if (word.Length > counterSymbols[0])
                    {
                        counterSymbols[0] = word.Length;
                        counterSymbols[1] = 1;
                    }
                    else if (word.Length == counterSymbols[0])
                    {
                        counterSymbols[1]++;
                    }
                }
                string[] arrayResultWords = new string[counterSymbols[1]];
                int counter = 0;
                foreach (string word in arrayWords)
                {
                    if (word.Length == counterSymbols[0])
                    {
                        arrayResultWords[counter] = word;
                        //Console.WriteLine(word);
                        counter++;
                    }
                }
                return arrayResultWords;
            }
            else
            {
                return nullAnswer;
            }
        }
    }
}
