using Tyuiu.TyazhovLA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.TyazhovLA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] x = new string[] { "������", "�������", "����", "������", "���", "����", "����", "������", "��������", "�������", "������", "�������" };
            int res = ds.Calculate(x);
            Assert.AreEqual(4, res);
        }
    }
}