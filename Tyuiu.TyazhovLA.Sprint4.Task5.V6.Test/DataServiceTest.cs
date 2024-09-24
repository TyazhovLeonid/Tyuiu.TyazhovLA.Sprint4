using Tyuiu.TyazhovLA.Sprint4.Task5.V6.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] wait = new int[5, 5]
                { { -6, 3, -5, 7, 5, },

                { 3, 5, 7, 4, 5 },

                { 5, 6, 4, 5, 4 },

                { 7, 4, 7, 3, 3 },

                { 4, 6, 5, 5, 6 } };
            int[,] res = ds.Calculate(wait);
            int[,] wait1 = new int[5, 5]
                { { -6, 1, -5, 1, 1, },

                { 1, 1, 1, 1, 1 },

                { 1, 1, 1, 1, 1 },

                { 1, 1, 1, 1, 1 },

                { 1, 1, 1, 1, 1 } };
            CollectionAssert.AreEqual(wait1, res);
        }
    }
}