using Tyuiu.AnishchenkoVA.Sprint1.Task1.V27.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}