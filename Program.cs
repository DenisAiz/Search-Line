using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("C каким словом отобразить строки: ");
            string searchWord = Console.ReadLine();

            var path = @"File\TheRoad.txt";

            var reader = new Reader();
            var filter = new Filter();
            var message = new Messager();

            var fileLines = reader.TextReading(path);
            var printMessage = filter.RowsFiltering(fileLines, searchWord);

            message.PrintMessage(printMessage);
        }
    }
}

