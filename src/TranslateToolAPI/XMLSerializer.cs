using System;
using System.IO;
using System.Xml.Serialization;

namespace TranslateToolAPI
{
    internal class XMLSerializer : ISerializable
    {
        public T Deserialize<T>()
        {
            throw new NotImplementedException();
        }

        public void Serialize<T>(string path, T _obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);

            xml.Serialize(file, _obj);
        }

        public void Serialize<T>(FileStream file, T _obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));

            xml.Serialize(file, _obj);
        }
    }
}
