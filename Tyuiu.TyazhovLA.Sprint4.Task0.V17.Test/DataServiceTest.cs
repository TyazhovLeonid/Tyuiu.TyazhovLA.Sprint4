using Tyuiu.TyazhovLA.Sprint4.Task0.V17.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.GetSumEvenArrEl(array: new[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 });
            Assert.AreEqual(34, res);
        }
    }
}