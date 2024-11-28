using Tyuiu.GubanovaSO.Sprint5.Task4.V30.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V30.txt");
            Console.Write("Функция от данного x равна " + ds.LoadFromDataFile(path));
            Console.ReadLine();
        }
    }
}
