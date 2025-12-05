using Tyuiu.ZavyalovKA.Sprint6.Task1.V25.Lib;
namespace Tyuiu.ZavyalovKA.Sprint6.Task1.V25.Test
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
            valueWaitArray[0] = -0.29;
            valueWaitArray[1] = -0.16;
            valueWaitArray[2] = -0.04;
            valueWaitArray[3] = 0.08;
            valueWaitArray[4] = 0.23;
            valueWaitArray[5] = 0.38;
            valueWaitArray[6] = 0.52;
            valueWaitArray[7] = 0.63;
            valueWaitArray[8] = 0.65;
            valueWaitArray[9] = 0.46;
            valueWaitArray[10] = -0.29;
            double[] res;
            res = new double[len]; 
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
