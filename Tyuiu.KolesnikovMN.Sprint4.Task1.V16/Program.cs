using Tyuiu.KolesnikovMN.Sprint4.Task1.V16.Lib;

namespace Tyuiu.KolesnikovMN.Sprint4.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан одномерный целочисленный массив на 13 элементов заполненный        *");
            Console.WriteLine("*  значениями с клавиатуры в диапазоне от 3 до 8 подсчитать произведение  *");
            Console.WriteLine("*  нечетных элементов массива.                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int len;

            Console.WriteLine("Введите количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            Console.WriteLine();
            for (int j = 0; j < len; j++)
            {
                Console.WriteLine($"Введите значние {j} элемента массива");
                numsArray[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение нечетных элементов массива = {ds.Calculate(numsArray)}");
            Console.ReadKey();
        }
    }
}
