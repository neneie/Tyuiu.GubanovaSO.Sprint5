using Tyuiu.GubanovaSO.Sprint5.Task4.V30.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V30.txt");
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(52.842, res);
        }
    }
}