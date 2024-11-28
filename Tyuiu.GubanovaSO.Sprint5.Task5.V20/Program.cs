using Tyuiu.GubanovaSO.Sprint5.Task5.V20.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V20.txt");
            Console.Write("Среднее значение чисел в файле " + ds.LoadFromDataFile(path));
            Console.ReadLine();
        }
    }
}
