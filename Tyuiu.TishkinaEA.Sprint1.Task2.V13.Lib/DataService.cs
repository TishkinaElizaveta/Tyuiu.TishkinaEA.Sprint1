using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TishkinaEA.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int value)
        {
             const double MilesToKilometers = 1.609344;
            double kilometers = value * MilesToKilometers;

            return Math.Round(kilometers, 3);
        }
    }
}
