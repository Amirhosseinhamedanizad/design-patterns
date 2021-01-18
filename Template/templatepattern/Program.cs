using System;

namespace templatepattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tracker1 = new Tracker1();
            //tracker1.Template();

            //var tracker2 = new Tracker2();
            //tracker2.Template();

            var csvParser = new CSVParser();
            csvParser.Template("csv");

            var xmlParser = new XMLParser();
            xmlParser.Template("xml");
            Console.ReadLine();
        }
    }
}
