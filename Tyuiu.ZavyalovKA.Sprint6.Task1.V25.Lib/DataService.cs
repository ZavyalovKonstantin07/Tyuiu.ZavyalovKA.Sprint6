using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ZavyalovKA.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint6Task1V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) - 2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2;
                    y = Math.Round(y, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
