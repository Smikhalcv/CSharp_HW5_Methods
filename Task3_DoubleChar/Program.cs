using System;

namespace Task3_DoubleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string greeting = "Задача 3 - удаление повторяющихся букв!";
            Console.CursorLeft = (Console.WindowWidth - greeting.Length) / 2;
            Console.WriteLine(greeting);
            Console.ResetColor();
            Console.WriteLine("Введите текст для преобразования -");
            string text = Console.ReadLine();
            MakeString newText = new MakeString();
            string newString = newText.ThinString(text);
            Console.WriteLine("Преобразованный текст:");
            Console.WriteLine(newString);
        }
    }
}
