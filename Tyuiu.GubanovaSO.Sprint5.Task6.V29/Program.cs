﻿using Tyuiu.GubanovaSO.Sprint5.Task6.V29.Lib;

namespace Tyuiu.GubanovaSO.Sprint5.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V29.txt");
            Console.Write("Количество слов длиной 7 символов равно " + ds.LoadFromDataFile(path));
            Console.ReadLine();
        }
    }
}
