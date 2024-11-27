using Tyuiu.GubanovaSO.Sprint5.Task7.V5.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V5.txt");
            string newpath = ds.LoadDataAndSave(path);
            Assert.AreEqual("Hello, Мир! Это Is My First Program.", File.ReadAllText(newpath));
        }
    }
}