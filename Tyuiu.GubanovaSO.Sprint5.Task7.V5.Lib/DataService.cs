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
            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 1 && reg.IsMatch(text[i + 1].ToString()) && text[i] == ' ') continue;
                if (!reg.IsMatch(text[i].ToString())) newtext += text[i];
            }
            string newpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");
            File.WriteAllText(newpath, newtext);
            return newpath;
        }
    }
}
