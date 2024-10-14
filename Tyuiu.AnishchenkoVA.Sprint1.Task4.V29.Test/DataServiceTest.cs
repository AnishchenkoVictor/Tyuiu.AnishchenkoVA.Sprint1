using System;
using Tyuiu.AnishchenkoVA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double z = 0.167;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(z, res);
        }
    }
}