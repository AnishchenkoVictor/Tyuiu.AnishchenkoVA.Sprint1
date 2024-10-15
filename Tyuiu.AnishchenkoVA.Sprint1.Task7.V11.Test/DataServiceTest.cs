using Tyuiu.AnishchenkoVA.Sprint1.Task7.V11.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            double res = 0.751;
            double z = ds.Calculate(x, y);
            Assert.AreEqual(res, z);
        }
    }
}