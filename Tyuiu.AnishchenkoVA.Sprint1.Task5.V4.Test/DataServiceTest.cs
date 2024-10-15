using Tyuiu.AnishchenkoVA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 15000;
            int res = ds.SecondsToHours(k);
            Assert.AreEqual(4, res);
        }
    }
}