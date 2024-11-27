using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GubanovaSO.Sprint5.Task3.V15.Lib
{
    public class DataService: ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            double f = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            writer.Write(f);
            writer.Close();
            return path;
        }
    }
}
