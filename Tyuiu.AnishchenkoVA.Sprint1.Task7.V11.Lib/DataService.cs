using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round((Math.Pow(Math.Log(Math.Sin(x)), x))/(Math.Log(1 + Math.Pow(x, 2))) + (y - Math.Sqrt(Math.Abs(x))), 3);
            return res;
        }
    }
}
