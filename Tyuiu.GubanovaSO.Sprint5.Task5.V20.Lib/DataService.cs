using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GubanovaSO.Sprint5.Task5.V20.Lib
{
    public class DataService: ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            string[] text = File.ReadAllText(path).Replace('.', ',').Split(' ');
            double[] nums = new double[text.Length];
            double sum = 0;
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                nums[i] = double.Parse(text[i]);
                if (nums[i] < 10 && nums[i] > -10 && nums[i] % 1 == 0)
                {
                    sum += nums[i];
                    count++;
                }
            }
            double res = sum / count;
            return res;
        }
    }
}
