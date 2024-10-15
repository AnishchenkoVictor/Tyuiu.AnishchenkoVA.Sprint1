using Tyuiu.AnishchenkoVA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string a = "abv ! vvv ? ww";
            bool res = ds.CheckSpecSymbols(a);
            Assert.AreEqual(true, res);
        }
    }
}