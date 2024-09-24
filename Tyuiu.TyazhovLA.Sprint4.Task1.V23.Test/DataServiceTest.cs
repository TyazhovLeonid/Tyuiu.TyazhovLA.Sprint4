using Tyuiu.TyazhovLA.Sprint4.Task1.V23.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.Calculate(array: new[] { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 });
            Assert.AreEqual(36, res);
        }
    }
}