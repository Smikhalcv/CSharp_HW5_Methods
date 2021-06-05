using System;

namespace Task5_FunctionAckerman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string greeting = "Задача 5 - функция Аккермана с помощью рекурсии!";
            Console.CursorLeft = (Console.WindowWidth - greeting.Length) / 2;
            Console.WriteLine(greeting);
            Console.ResetColor();
            Console.WriteLine("Функция Аккермана - является одним из простейших примеров полной вычислимой функции," +
                "\nкоторая не является примитивно-рекурсивной.\n" +
                "Записывается как А(m, n).");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(не рекомендуется указывать m больше 3)");
            Console.ResetColor();
            int m = CheckInt.CheckPositivInt('m');
            int n = CheckInt.CheckPositivInt('n');
            Console.WriteLine($"Результат вычислений - {Ackerman.FuncAckerman(m, n)}");
        }
    }
}
