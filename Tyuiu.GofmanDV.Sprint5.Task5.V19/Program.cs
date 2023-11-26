using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GofmanDV.Sprint5.Task5.V19.Lib;

namespace Tyuiu.GofmanDV.Sprint5.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Гофман Д. В. | СМАРТб-23-1";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                     *");
            Console.WriteLine("* Таск #5                                                                              *");
            Console.WriteLine("* Вариaнт #19                                                                          *");
            Console.WriteLine("* Выполнил: Гофман Даниил Викторович     | СМАРТб-23-1                                 *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
