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

            double sum;
            double result;

            // Формализация ряда в цикле
            result = 0;

            for (int k = 1; k <= 10; k++)
            {
                sum = 0;

                for (int n = 1; n <= k; n++)
                {
                    sum += Math.Tan(k * n); // Сумма tg(k*m)
                }

                result += sum / k;
            }

            // Вывод результата
            Console.WriteLine($"Результат вычисления ряда: {result:F6}");

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey(true);
        }
    }
}