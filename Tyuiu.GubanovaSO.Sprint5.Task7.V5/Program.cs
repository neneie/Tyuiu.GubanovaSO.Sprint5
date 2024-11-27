using Tyuiu.GubanovaSO.Sprint5.Task7.V5.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 2.12x^3 + 1.05x^2 + 4.1x * 2, x=2                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V5.txt");
            Console.Write("Новая строка: " + File.ReadAllText(ds.LoadDataAndSave(path)));
            Console.ReadLine();
        }
    }
}
