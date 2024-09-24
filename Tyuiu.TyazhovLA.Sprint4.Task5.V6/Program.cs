using Tyuiu.TyazhovLA.Sprint4.Task5.V6.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random r = new Random();
            Console.Title = "Спринт #4 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = r.Next(-3, 5);
                }
            }
            for (int i = 0; i < 5; i++) { Console.WriteLine(); for (int j = 0; j < 5; j++) { Console.Write(matrix[i, j]+"\t");  } }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(matrix);
            for (int i = 0; i < 5; i++) { Console.WriteLine(); for (int j = 0; j < 5; j++) { Console.Write(res[i, j] + "\t"); } }
            Console.ReadLine();


        }
    }
}
