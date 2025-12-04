using Tyuiu.ZavyalovKA.Sprint6.Task0.V29.Lib;
namespace Tyuiu.ZavyalovKA.Sprint6.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.722;
            Assert.AreEqual(wait, res);
        }
    }
}
