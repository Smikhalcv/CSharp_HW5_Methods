using System;

namespace Task2_Text
{
    class Program
    {
        /// <summary>
        /// Приветствие и выбор необходимого режима
        /// </summary>
        /// <returns></returns>
        static int Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string greeting = "Задача 2 - самые длиный и короткие слова!";
            Console.CursorLeft = (Console.WindowWidth - greeting.Length) / 2;
            Console.WriteLine(greeting);
            Console.ResetColor();
            Console.WriteLine("Выберете необходимое действие:" +
                "\n1 - найти и отобразить первое слово с минимальным количеством символов;" +
                "\n2 - найти и отобразить массив слов с максимальным количеством слов;");
            int mode;
            while (true)
            {
                try
                {
                    mode = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                    throw;
                }
                if (mode == 1 || mode == 2)
                {
                    break;
                }
            }
            return mode;
        }
        static void Main(string[] args)
        {
            int mode = Greeting();
            Console.WriteLine("Введите проверяемый текст -");
            string text = Console.ReadLine();
            if (mode == 1)
            {
                string minSymbols = StrMinSymbols.MinSymbols(text);
                Console.WriteLine($"Ответ - {minSymbols}");
            }
            else if (mode == 2)
            {
                string[] maxSymbols = ArrayMaxSymbols.MaxSymbols(text);
                Console.WriteLine("Ответ:");
                for (int i = 0; i < maxSymbols.Length; i++)
                {
                    Console.WriteLine(maxSymbols[i]);
                }
            }
        }
    }
}
