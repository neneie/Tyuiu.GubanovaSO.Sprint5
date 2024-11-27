using Tyuiu.GubanovaSO.Sprint5.Task0.V21.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.SaveToFileTextData(3);
            Assert.AreEqual(File.ReadAllText(res), (1.741).ToString());
        }
    }
}