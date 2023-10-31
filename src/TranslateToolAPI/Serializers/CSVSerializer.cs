using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;


namespace TranslateToolAPI
{
    internal class CSVSerializer : ISerializer
    {
        public T Deserialize<T>(string path)
        {
            StreamReader reader = new StreamReader(path);
            CsvReader Csv = new CsvReader(reader,CultureInfo.InvariantCulture);
            
           return Csv.GetRecord<T>();
        }
        
        public T Deserialize<T>(FileStream file)
        {
            StreamReader reader = new StreamReader(file);
            CsvReader Csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            return Csv.GetRecord<T>();
            
        }


        public void Serialize<T>(string path, T _obj)
        {
            StreamWriter writer = new StreamWriter(path);
            CsvWriter Csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
               


            Csv.WriteField<T>(_obj);

        }
        
        public void Serialize<T>(FileStream file, T _obj)
        {

            StreamWriter writer = new StreamWriter(file);
            CsvWriter Csv = new CsvWriter(writer, CultureInfo.InvariantCulture);



            Csv.WriteField<T>(_obj);
        }
    }
}
