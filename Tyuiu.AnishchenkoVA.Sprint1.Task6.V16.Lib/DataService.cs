using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            bool x = false;
            int a = value.IndexOf('!');
            int b = value.IndexOf('?');
            if (a + b > 1)
            {
                x = true;
                return x;
            }
            return x;
        }
    }
}
