using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TranslateToolAPI;

namespace TranslateToolAPI
{
    internal class CsParser
    {
        private StreamWriter _writer;
        public void Parse<T>(string path, T obj)
        {
            _writer = new StreamWriter(path + "Generated_CS.cs");

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
                _writer.WriteLine("TranslateItems.Add(new TranslateItem());");
                _writer.WriteLine(" TranslateItems["+i+"].Id = "+i+";");
                _writer.WriteLine("TranslateItems["+i+"].Translations = new Dictionary<string, string>()");
                _writer.WriteLine("{");
                _writer.WriteLine(" {" + "\"fr_FR\","+ "\"" + Application.translateItems.ElementAt(i).Translations["fr_FR"] + "\" }," );
                _writer.WriteLine(" {" + "\"en_US\","+ "\"" + Application.translateItems.ElementAt(i).Translations["en_US"] + "\" }," );
                _writer.WriteLine(" {" + "\"es_ES\","+ "\"" + Application.translateItems.ElementAt(i).Translations["es_ES"] + "\" }," );
                _writer.WriteLine(" }");
                _writer.WriteLine(";");



            }

            _writer.WriteLine("}");
            _writer.WriteLine("}");
           
        }
    }
}
//"fr_FR" "en_US" "es_ES"
internal partial class Generated_CS
{
        
    public List<TranslateItem> TranslateItems { get; set; }
    
   

    Generated_CS() 
    {

        TranslateItems.Add(new TranslateItem());
        TranslateItems[0].Id = 0;
        TranslateItems[0].Translations = new Dictionary<string, string>() { { "truc", "haha" } };
    
    }
 

}
