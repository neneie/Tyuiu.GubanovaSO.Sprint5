using Tyuiu.GubanovaSO.Sprint5.Task7.V5.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V5.txt");
            Console.Write("Новая строка: " + File.ReadAllText(ds.LoadDataAndSave(path)));
            Console.ReadLine();
        }
    }
}
