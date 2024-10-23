using Tyuiu.KolesnikovMN.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дана строка из одноразрядных цифр \"135792468\". Преобразуйте ее в     *");
            Console.WriteLine("*  матрицу 3 на 3 и подсчитайте количество четных чисел.                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int rows = 3;
            int columns = 3;
            
            string str = "135792468";
            int[,] numsArray = new int[rows, columns];

            int index = 0;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{str[index]} \t");
                    index++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество чётных чисел = {ds.Calculate(rows, columns, str)}");
            Console.ReadKey();
        }
    }
}
