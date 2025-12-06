using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZavyalovKA.Sprint6.Task4.V27.Lib
{
    public class DataService : ISprint6Task4V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = (stopValue - startValue) + 1; 
            double[] valueArray = new double[length]; 
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = (Math.Cos(x) / (x + 1)) - (Math.Cos(x) * 1.3) + (3 * x);
                y = Math.Round(y, 2); 
                valueArray[count] = y; 
                count++;
            }
            return valueArray;
        }
    }
}