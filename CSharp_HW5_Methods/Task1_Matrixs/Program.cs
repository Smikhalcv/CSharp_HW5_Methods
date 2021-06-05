using System;

namespace Task1_Matrixs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Матрицы!");
            Console.WriteLine("Выберете действие:");
            Console.WriteLine("1 - умножение матрицы на число;");
            Console.WriteLine("2 - сложение матриц;");
            Console.WriteLine("3 - вычитание матриц;");
            Console.WriteLine("4 - умножение двух матриц;");

            int mode;

            while (true)
            {
                try
                {
                    mode = Convert.ToInt32(Console.ReadLine());
                    if (mode >= 1 && mode <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Укажите число от 1 до 4 ");
                    Console.WriteLine("1 - умножение матрицы на число;");
                    Console.WriteLine("2 - сложение матриц;");
                    Console.WriteLine("3 - вычитание матриц;");
                    Console.WriteLine("4 - умножение двух матриц;");
                }
                catch
                {
                    Console.WriteLine("Укажите число от 1 до 4 ");
                    Console.WriteLine("1 - умножение матрицы на число;");
                    Console.WriteLine("2 - сложение матриц;");
                    Console.WriteLine("3 - вычитание матриц;");
                    Console.WriteLine("4 - умножение двух матриц;");
                }

            }
            Console.WriteLine(mode);

            ActionOnMatrix multiplierMatrix = new ActionOnMatrix();

            switch (mode)
            {
                case 1:
                    multiplierMatrix.MyltiplaingMatrixOnNumber();
                    break;
                case 2:
                    multiplierMatrix.AdditionMatrix();
                    break;
                case 3:
                    multiplierMatrix.SubtractionMatrix();
                    break;
                case 4:
                    multiplierMatrix.MultiplicationMatrix();
                    break;
            }
        }
    }
}
