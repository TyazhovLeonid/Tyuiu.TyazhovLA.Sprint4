﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TyazhovLA.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(x => x.Length < 6);return count;
        }
        
    }
}
