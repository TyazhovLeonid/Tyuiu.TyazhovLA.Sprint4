using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TyazhovLA.Sprint4.Task5.V6.Lib
{
    public class DataService : ISprint4Task5V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int ryad = matrix.GetUpperBound(0) + 1;
            int stolb = matrix.Length;

            for (int i = 0; i < ryad; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] >  0) matrix[i, j]=1;
                }

            }
            return matrix;
        }
    }
}
