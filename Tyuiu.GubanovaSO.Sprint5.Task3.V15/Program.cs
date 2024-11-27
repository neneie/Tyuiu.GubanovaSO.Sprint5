using Tyuiu.GubanovaSO.Sprint5.Task3.V15.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            BinaryReader reader = new BinaryReader(File.Open(ds.SaveToFileTextData(x), FileMode.Open));

            Console.Write("Функция от данного x равна " + reader.ReadDouble());
            Console.ReadLine();
        }
    }
}
