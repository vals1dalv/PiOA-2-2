using System;

namespace lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White; // Цвет консоли
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int n; // Кол-во элементов ряда
            double result = 0;

            // Ввод с проверкой
            for (; ; )
            {
                Console.Write("Введите кол-во элементов ряда (n>= 4): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 4)
                {
                    break;
                }
                Console.WriteLine("Ошибка: введите целое число больше или равное 4");
            }

            // Формализация ряда в цикле
            double numerator = 0;
            double denominator = 0;

            for (int k = 1; k <= n; k++)
            {
                // Вычисление элемента ряда
                double term = Math.Tan(2 * k);
                numerator += term; // Добавл. элемента к числит.
                denominator += k; // Добавл. элемента к знаменат.
            }

            // Вычисление результата
            result = numerator / denominator;

            // Вывод результата
            Console.WriteLine($"Сумма первых {n} элементов ряда: {result:F6}");

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey(true);
        }
    }
}