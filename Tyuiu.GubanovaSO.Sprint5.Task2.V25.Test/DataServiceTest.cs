using Tyuiu.GubanovaSO.Sprint5.Task2.V25.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                {4, 8, 5 },
                {1, 4, 2 },
                {4, 9, 9 }
            };
            string wait = "4;8;0\n0;4;2\n4;0;0";
            string res = File.ReadAllText(ds.SaveToFileTextData(matrix)).Trim();
            Assert.AreEqual(wait, res);
        }
    }
}