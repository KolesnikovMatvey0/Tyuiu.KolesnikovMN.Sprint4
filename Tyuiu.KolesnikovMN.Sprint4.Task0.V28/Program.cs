using Tyuiu.KolesnikovMN.Sprint4.Task0.V28.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан одномерный целочисленный массив на 10 элементов заполненный        *");
            Console.WriteLine("*  статическими значениями в диапазоне от 0 до 9 подсчитать произведение  *");
            Console.WriteLine("*  четных элементов массива.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[] array = new int[] { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение четных элементов массива = {ds.GetMultEvenArrEl(array)}");
            Console.ReadKey();
        }
    }
}
