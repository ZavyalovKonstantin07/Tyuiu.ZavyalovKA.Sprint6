using Tyuiu.ZavyalovKA.Sprint6.Task7.V1.Lib;
namespace Tyuiu.ZavyalovKA.Sprint6.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint6\Tyuiu.ZavyalovKA.Sprint6.Task7.V1\bin\Debug\net8.0-windows\InPutDataFileTask7V1.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);
        }
    }
}
