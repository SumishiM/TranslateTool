using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace TranslateToolAPI
{
    internal class CSVSerializer : ISerializable
    {
        public T Deserialize<T>(string path)
        {
            throw new NotImplementedException();
        }
        
        public T Deserialize<T>(FileStream file)
        {
            throw new NotImplementedException();
        }


        public void Serialize<T>(string path, T _obj)
        {

            throw new NotImplementedException();
        }
        
        public void Serialize<T>(FileStream file, T _obj)
        {

            throw new NotImplementedException();
        }
    }
}
