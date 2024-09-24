using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TyazhovLA.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int p = 1;
            int ryad = array.GetUpperBound(0) + 1;
            int stolb = array.Length;
            int j = 0;
            for (int i = 0; i<ryad; i++)
            {
                p*=array[i,j];
            }
            return p;
        }
    }
}
