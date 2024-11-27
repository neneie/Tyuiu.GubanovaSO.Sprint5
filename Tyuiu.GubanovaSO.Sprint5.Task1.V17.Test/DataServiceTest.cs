using Tyuiu.GubanovaSO.Sprint5.Task1.V17.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5, stop = 5;
            string res = ds.SaveToFileTextData(start, stop);
            Assert.AreEqual(Convert.ToString(2), File.ReadAllText(res));
        }
    }
}