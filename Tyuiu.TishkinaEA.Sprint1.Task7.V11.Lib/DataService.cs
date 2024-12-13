using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TishkinaEA.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Pow(Math.Log(Math.Sin(x)), x);
            double denominator = Math.Log(1 + Math.Pow(x, 2));
            double z = (numerator / denominator) + (y - Math.Sqrt(Math.Abs(x)));
            return Math.Round(z, 3);
        }
    }
}
