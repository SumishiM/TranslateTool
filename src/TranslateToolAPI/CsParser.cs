using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TranslateToolAPI
{
    internal class CsParser
    {
        private StreamWriter _writer;
        public void Parse<T>(string path, T obj)
        {
            _writer = new StreamWriter(path);

            _writer.WriteLine("using System;");
            _writer.WriteLine("using System.Collections.Generic;");
            _writer.WriteLine("internal partial class Generated_CS");
            _writer.WriteLine("{");
            _writer.WriteLine("public Guid Id { get; set; }");
            _writer.WriteLine(" public Dictionary<string, string> Translations { get; set; }");
            _writer.WriteLine("Generated_CS()");
            _writer.WriteLine("{");


            for (int i = 0; i < Application.translateItems.Count; i ++)
            {
                _writer.WriteLine("Id.Add(" + Application.translateItems.ElementAt(i).Id +")");
                //_writer.WriteLine();


            }

            _writer.WriteLine("}");
            _writer.WriteLine("}");
           
        }
    }
}

internal partial class Generated_CS
{
        public List<uint> Id { get; set; }
    public Dictionary<string, string> Translations { get; set; }
    
   

    Generated_CS() 
    {
    
    
    
    }
 

}
