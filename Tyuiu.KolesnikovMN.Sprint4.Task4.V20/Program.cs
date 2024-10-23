using Tyuiu.KolesnikovMN.Sprint4.Task4.V20.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("*  значениями с клавиатуры в диапазоне от 4 до 8. Заменить четные         *");
            Console.WriteLine("*  элементы массива на 1.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

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
                    Console.WriteLine($"Введите значние {i},{j} элемента массива");
                    matrix [i,j] = Convert.ToInt32(Console.ReadLine());
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
