using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GubanovaSO.Sprint5.Task1.V17.Lib
{
    public class DataService: ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double[] res = new double[11];
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            File.WriteAllText(path, "");
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) + 1 == 0) res[i + 5] = 0;
                else
                {
                    res[i + 5] = Math.Round((2* i - 4 + (2*i-1)/(Math.Sin(i)+1)), 2);
                }
                File.AppendAllText(path, res[i + 5].ToString() + "\n");
            }
            return path;
        }
    }
}
