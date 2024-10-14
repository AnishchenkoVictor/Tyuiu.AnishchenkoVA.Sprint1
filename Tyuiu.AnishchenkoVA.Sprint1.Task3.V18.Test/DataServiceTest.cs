using Tyuiu.AnishchenkoVA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 6;
            double b = 6;
            double c = 3;
            double z = 4;
            Assert.AreEqual(z, ds.HowManySquares(a, b, c));
        }
    }
}