using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TyazhovLA.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] matrix)
        {
            int p = 0;
            int ryad = matrix.GetUpperBound(0) +1 ;
            int stolb = matrix.Length;
            
            for (int i = 0; i < ryad; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i,j] %2 == 0)  p += matrix[i, j];
                }
                    
            }
            return p;
        }
    }
}
