using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GubanovaSO.Sprint5.Task7.V5.Lib
{
    public class DataService: ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string newtext = "";
            Regex reg = new Regex("[A-Za-z]");
            foreach (char c in text)
            {
                if (!reg.IsMatch(c.ToString())) newtext += c;
            }
            string newpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");
            File.WriteAllText(newpath, newtext);
            return newpath;
        }
    }
}
