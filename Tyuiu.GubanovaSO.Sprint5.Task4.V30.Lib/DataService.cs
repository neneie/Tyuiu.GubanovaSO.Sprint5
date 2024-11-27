using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GubanovaSO.Sprint5.Task4.V30.Lib
{
    public class DataService: ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            text = text.Replace('.', ',');
            double x = double.Parse(text);
            Console.WriteLine(x);
            double f = (Math.Pow(x, 3) - Math.Tan(x) + 2.03* x);
            return Math.Round(f, 3);
        }
    }
}
