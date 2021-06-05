using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_FunctionAckerman
{
    class Ackerman
    {
        /// <summary>
        /// Функция Аккермана.
        /// </summary>
        /// <param name="m">Натуральное положительное число</param>
        /// <param name="n">Натуральное положительно число</param>
        /// <returns>Натуральное число</returns>
        public static int FuncAckerman(int m, int n)
        {
            // Описание функции аккермана с помощью рекурсии
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return FuncAckerman(m - 1, 1);
            }
            else
            {
                return FuncAckerman(m - 1, FuncAckerman(m, n - 1));
            }
        }
    }
}
