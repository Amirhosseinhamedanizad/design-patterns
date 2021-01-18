using System;
using System.Collections.Generic;
using System.Text;

namespace templatepattern
{
    public abstract class FileCompressor
    {
        public abstract void ParseFile(string file);

        public void Decode()
        {
            Console.WriteLine("Decode Started .....");
        }
        public void Template(string file)
        {
            //decoding is similar
            Decode();
            ParseFile(file);

        }
    }

    public class CSVParser : FileCompressor
    {
        //how to parse csv
        public override void ParseFile(string file)
        {
            Console.WriteLine($"{file} started parsing .....");
        }
    }

    public class XMLParser : FileCompressor
    {
        //how to parse xml file
        public override void ParseFile(string file)
        {
            Console.WriteLine($"{file} started parsing .....");
        }
    }
}
