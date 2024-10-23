using Tyuiu.KolesnikovMN.Sprint4.Task5.V27.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("*  случайными значениями в диапазоне от -5 до 7. Найти количество         *");
            Console.WriteLine("*  отрицательных элементов.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int colunms = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, colunms];

            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colunms; j++)
                {
                    matrix[i, j] = rnd.Next(-5, 8);
                }
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colunms; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Итоговый массив = {ds.Calculate(matrix)}");
            Console.ReadKey();
        }
    }
}
