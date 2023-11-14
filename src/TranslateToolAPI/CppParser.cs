using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToolAPI
{
    internal class CppParser
    {
        private StreamWriter _writer;
        public void Parse<T>(string path, T obj)
        {
            _writer = new StreamWriter(path + "TranslateItem.h");
            _writer.WriteLine("#include <std::map>");
            _writer.WriteLine("Namespace TranslateToolAPI");
            _writer.WriteLine("{");
            _writer.WriteLine("Class TranslateItem {");
            _writer.WriteLine("Public :");
            _writer.WriteLine("int Id;");
            _writer.WriteLine("std::map<std::string, std::string> Translation;");



            _writer.WriteLine("}");
            _writer.WriteLine("}");



            _writer = new StreamWriter(path + "TranslateItem.Cpp");

            _writer.WriteLine("#include <" + path + " TranslateItem.h>");
            _writer.WriteLine("Namespace TranslateToolAPI");
            _writer.WriteLine("{");
            _writer.WriteLine("void main()");
            _writer.WriteLine("{");


            _writer.WriteLine("}");
            _writer.WriteLine("}");



            _writer = new StreamWriter(path + "Generated_Cpp.h");

            _writer.WriteLine("#include <std::map>");
            _writer.WriteLine("#include <std::list>");
            _writer.WriteLine("Class TranslateItem;");


            _writer.WriteLine("Namespace TranslateToolAPI");
            _writer.WriteLine("{");
            _writer.WriteLine("Class Generated_CS {");
            _writer.WriteLine("Public :");
            _writer.WriteLine("std::list<std::map> Translations;");
            _writer.WriteLine("Generated_Cs::Generated_Cs();");



            _writer.WriteLine("}");
            _writer.WriteLine("}");







            _writer = new StreamWriter(path + "Generated_Cpp.cpp");
            _writer.WriteLine("#include <" + path + "Generated_Cpp.h>");
            _writer.WriteLine("#include <" + path + "TranslateItem.h>");
            _writer.WriteLine("Namespace TranslateToolAPI");
            _writer.WriteLine("{");
            _writer.WriteLine("Generated_Cs::Generated_Cs()");
            _writer.WriteLine("{");
            for (int i = 0; i < Application.translateItems.Count; i++)
            {
                _writer.WriteLine("Translations.Add(new TranslateItem());");
                _writer.WriteLine("Translations[" + i + "].Id = " + i + ";");
                _writer.WriteLine(" Translations[" + i + "].Translation = new std::map<std::string, std::string>() {  ");

                _writer.WriteLine("{\"fr_FR\", " + Application.translateItems.ElementAt(i).Translations["fr_FR"] + " },");
                _writer.WriteLine("{\"en_US\", " + Application.translateItems.ElementAt(i).Translations["en_US"] + " },");
                _writer.WriteLine("{\"es_ES\", " + Application.translateItems.ElementAt(i).Translations["es_ES"] + " },");

                _writer.WriteLine("};");
            }

            _writer.WriteLine("}");
            _writer.WriteLine("}");
        }
    }
}
