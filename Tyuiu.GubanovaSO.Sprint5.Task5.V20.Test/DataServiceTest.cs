using Tyuiu.GubanovaSO.Sprint5.Task5.V20.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V20.txt");
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(120, res);
        }
    }
}