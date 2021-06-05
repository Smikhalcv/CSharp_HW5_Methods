using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_DeterminitingProgression
{
    class ChangeProgression
    {
        /// <summary>
        /// Принимает массив чисел и проверяет является ли он арифметической прогрессией.
        /// </summary>
        public static bool ArithmeticProgression(int[] progression)
        {
            bool result = true;
            if (progression.Length > 2)
            {
                int step = progression[1] - progression[0];
                for (int i = 2; i < progression.Length; i++)
                {
                    if (progression[i] - progression[i - 1] != step)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else 
            { 
                result = false; 
            }
            return result;
        }

        /// <summary>
        /// Принимает массив чисел и проверяет является ли он геометрической прогрессией.
        /// </summary>
        public static bool GeometricProgression(int[] progression)
        {
            bool result = true;
            if (progression.Length > 2)
            {
                double step = progression[1] / progression[0];
                for (int i = 2; i < progression.Length; i++)
                {
                    if (progression[i] / progression[i - 1] != step)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Создаёт массив чисел из строки введённой пользователем.
        /// </summary>
        /// <returns>Массив чисел</returns>
        public static int[] InputIntProgression()
        {
            bool flag = true;
            int[] intArray = null;
            while (flag)
            {
                Console.WriteLine("Введите цифровую последовательность -");
                string strArray = Console.ReadLine();
                char[] charSeparators = new char[] { ' ', ',', '!', '?', '.', '/', ';' }; // удаляемые символы
                string[] arrayWords = strArray.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (arrayWords.Length > 0)
                { 
                    intArray = new int[arrayWords.Length];
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        try
                        {
                            intArray[i] = Convert.ToInt32(arrayWords[i]);
                            flag = false;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Последовательнасть должна состоять из чисел!");
                            flag = true;
                            break;
                            throw;
                        }
                    }
                }
            }
            return intArray;
        }
    }
}
