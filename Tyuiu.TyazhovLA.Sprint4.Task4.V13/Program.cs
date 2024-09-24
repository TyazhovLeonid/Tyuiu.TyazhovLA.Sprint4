using Tyuiu.TyazhovLA.Sprint4.Task4.V13.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task4.V13
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] wait = new int[5, 5]
                { { 6, 3, 5, 7, 5, },

                { 3, 5, 7, 4, 5 },

                { 5, 6, 4, 5, 4 },

                { 7, 4, 7, 3, 3 },

                { 4, 6, 5, 5, 6 } };
            Console.WriteLine("Матрица: 6, 3, 5, 7, 5");

            Console.WriteLine("         3, 5, 7, 4, 5");

            Console.WriteLine("         5, 6, 4, 5, 4");

            Console.WriteLine("         7, 4, 7, 3, 3");

            Console.WriteLine("         4, 6, 5, 5, 6");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(wait));
            Console.ReadKey();

        }
    }
}
