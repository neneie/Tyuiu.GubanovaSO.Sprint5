using Tyuiu.GubanovaSO.Sprint5.Task0.V21.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Функция от данного x равна " + File.ReadAllText(ds.SaveToFileTextData(x)));
            Console.ReadLine();
        }
    }
}
