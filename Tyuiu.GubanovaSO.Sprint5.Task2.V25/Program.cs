using Tyuiu.GubanovaSO.Sprint5.Task2.V25.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3];
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Введите {0} строку матрицы через пробел: ", i + 1);
                string[] input = Console.ReadLine().Split(" ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(input[j]);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = File.ReadAllText(ds.SaveToFileTextData(matrix)).Trim().Split(" ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(res[matrix.GetLength(j) * i + j + i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
