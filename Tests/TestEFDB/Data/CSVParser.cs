using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestEFDB.Data.Interfaces;

namespace TestEFDB.Data
{
    class CSVParser
    {
        static void CsvFileParser(string path)
        {
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";", ",");
                while (!parser.EndOfData)
                {
                    //А тут должно быть добавление данных по строчкам...
                }
            }
        }
    }
}
