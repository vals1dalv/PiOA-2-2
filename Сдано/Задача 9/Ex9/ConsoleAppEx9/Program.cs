using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // Размер массива
            double[] numbers; // Массив
            int indexMax = 0;
            int indexMin = 0;

            Console.BackgroundColor = ConsoleColor.White; // Цвет консоли
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Введите кол-во элементов одномерного массива: "); // Ввод длины массива
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Ошибка! Введите целое положительное число: ");
            }

            numbers = new double[n];

            for (int i = 0; i < n; i++) // Ввод элементов массива
            {
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                while (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Ошибка! Введите корректное числовое значение: ");
                }
            }

            Console.Write("numbers = ("); // Вывод массива
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i]);
                if (i < n - 1) Console.Write(", ");
            }
            Console.WriteLine(")");

            // Поиск индексов макс. и мин. элементов
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > numbers[indexMax]) indexMax = i;
                if (numbers[i] < numbers[indexMin]) indexMin = i;
            }

            // Вывод результата
            Console.WriteLine("Индекс наиб. элемента: " + indexMax);
            Console.WriteLine("Индекс наим. элемента: " + indexMin);
            Console.WriteLine("Разность индексов наиб. и наим. элементов: " + (indexMax - indexMin));

            Console.WriteLine("Нажмите любую клавишу для завершения.");
            Console.ReadKey();
        }
    }
}
