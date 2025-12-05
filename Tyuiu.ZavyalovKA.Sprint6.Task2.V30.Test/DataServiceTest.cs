using Tyuiu.ZavyalovKA.Sprint6.Task2.V30.Lib;
namespace Tyuiu.ZavyalovKA.Sprint6.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = -6.72;
            valueWaitArray[1] = -12.31;
            valueWaitArray[2] = -10.37;
            valueWaitArray[3] = -7.00;
            valueWaitArray[4] = -2.62;
            valueWaitArray[5] = 1.83;
            valueWaitArray[6] = 4.49;
            valueWaitArray[7] = 3.78;
            valueWaitArray[8] = 1.58;
            valueWaitArray[9] = 9.37;
            valueWaitArray[10] = 23.76;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}