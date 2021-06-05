using System;

namespace Task4_DeterminitingProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string greeting = "Задача 4 - определение последовательности!";
            Console.CursorLeft = (Console.WindowWidth - greeting.Length) / 2;
            Console.WriteLine(greeting);
            Console.ResetColor();
            int[] intArray = ChangeProgression.InputIntProgression();
            if (ChangeProgression.ArithmeticProgression(intArray))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Последовательность является арифметической последовательностью!");
                Console.ResetColor();
            }
            else if (ChangeProgression.GeometricProgression(intArray))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Последовательность является геометрической последовательностью!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Последовательность не является ни арифметической ни геометрической последовательностью!");
                Console.ResetColor();
            }
        }
    }
}
