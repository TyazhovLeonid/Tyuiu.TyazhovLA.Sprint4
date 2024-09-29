using Tyuiu.TyazhovLA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "10293847"; int n =4; int m = 2;
            int res = ds.Calculate(n, m,str);
            Assert.AreEqual(4,res);

        }
    }
}