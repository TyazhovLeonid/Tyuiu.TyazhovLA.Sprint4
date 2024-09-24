using Tyuiu.TyazhovLA.Sprint4.Task3.V29.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] wait = { { 9, 9, 8, 6, 9, },

                           { 5, 8, 8, 8, 7, },

                            {6, 5, 9, 7, 9, },

                            {7, 7, 9, 7, 8, },

                            {8, 5, 8, 5, 5, } };
            Console.WriteLine("Матрица: 9, 9, 8, 6, 9");

            Console.WriteLine("         5, 8, 8, 8, 7");

            Console.WriteLine("         6, 5, 9, 7, 9");

            Console.WriteLine("         7, 7, 9, 7, 8");

            Console.WriteLine("         8, 5, 8, 5, 5");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(wait));
            Console.ReadKey();

        }
    }
}
