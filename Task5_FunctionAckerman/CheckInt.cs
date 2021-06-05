using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_FunctionAckerman
{
    class CheckInt
    {
        /// <summary>
        /// Принимает число от пользователя и проверяет, чтоб оно было больше 0
        /// </summary>
        /// <param name="symbol">char обозначение символа</param>
        /// <returns>натуральное число</returns>
        public static int CheckPositivInt(char symbol)
        {
            int number;
            while (true)
            {
                Console.WriteLine($"Укажите число {symbol}:");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                    {
                        break;
                    }
                }
                catch (Exception)
                { }
            }
            return number;
        }
    }
}
