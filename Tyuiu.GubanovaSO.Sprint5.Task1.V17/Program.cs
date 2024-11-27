using Tyuiu.GubanovaSO.Sprint5.Task1.V17.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int start = -5, end = 5;
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(start, end);

            string[] res = File.ReadAllText(path).Trim().Split("\n");
            Console.WriteLine("+--------+--------+\n" +
                              "|   x    |  f(x)  |\n" +
                              "+--------+--------+");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("|{0,8:d}|{1,8:f2}|", (i - 5), res[i]);
                Console.WriteLine("+--------+--------+");
            }

            Console.ReadLine();
        }
    }
}
