using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GubanovaSO.Sprint5.Task0.V21.Lib
{
    public class DataService: ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            double f = Math.Round((x*x + 1) / Math.Sqrt(4*x*x - 3), 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            Console.WriteLine(path);
            File.WriteAllText(path, f.ToString());
            return path;
        }
    }
}
