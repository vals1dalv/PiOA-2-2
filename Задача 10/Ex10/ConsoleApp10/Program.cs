using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount; // Кол-во строк
            int colCount; // Кол-во столбцов
            double[,] matrix; // Исходная матрица

            Console.BackgroundColor = ConsoleColor.White; // Цвет консоли
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Ввод размерности с ограничением на размер
            Console.Write("Введите кол-во строк матрицы (>=4): ");
            while (!int.TryParse(Console.ReadLine(), out rowCount) || rowCount < 4)
            {
                Console.Write("Ошибка! Введите целое число, не меньше 4: ");
            }

            Console.Write("Введите кол-во столбцов матрицы (>=4): ");
            while (!int.TryParse(Console.ReadLine(), out colCount) || colCount != rowCount)
            {
                Console.Write("Ошибка! Введите целое число, не меньше 4 и равное числу строк: ");
            }

            int n = rowCount;
            matrix = new double[n, n];

            for (int i = 0; i < n; i++) // Ввод элементов матрицы
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите {j + 1}-й элемент {i + 1}-й строки: ");
                    while (!double.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.Write("Ошибка! Введите корректное числовое значение: ");
                    }
                }
            }

            Console.Clear(); // Очистка экрана после ввода

            Console.WriteLine("Исходная матрица:"); // Вывод матрицы
            PrintMatrix(matrix, n);

            double det = Determinant(matrix, n); // Вычисление определителя

            // Вывод результата
            Console.WriteLine();
            Console.WriteLine("Определитель матрицы: " + det);

            Console.WriteLine("Нажмите любую клавишу для завершения.");
            Console.ReadKey();
        }



        static void PrintMatrix(double[,] matrix, int n) // Ф-ия для вывода матрицы
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],8:0.##}");
                }
                Console.WriteLine(" |");
            }
        }

        static double Determinant(double[,] matrix, int n) // Вычисление определителя
        {
            if (n == 1) return matrix[0, 0];
            if (n == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            double det = 0;
            double[,] minor = new double[n - 1, n - 1];
            for (int k = 0; k < n; k++)
            {
                // Минор для элемента [0,k]
                for (int i = 1; i < n; i++)
                {
                    int col = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == k) continue;
                        minor[i - 1, col] = matrix[i, j];
                        col++;
                    }
                }
                det += (k % 2 == 0 ? 1 : -1) * matrix[0, k] * Determinant(minor, n - 1);
            }
            return det;
        }
    }
}
