using System;
using System.IO;
using System.Xml.Serialization;

namespace TranslateToolAPI
{
    internal class XMLSerializer : ISerializable
    {
        public T Deserialize<T>(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            FileStream file = new FileStream(path, FileMode.Open);

            T result = (T)xml.Deserialize(file);

            return result;
        }

        public T Deserialize<T>(FileStream file)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));

            T result = (T)xml.Deserialize(file);

            return result;
        }

        public void Serialize<T>(string path, T _obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);

            xml.Serialize(file, _obj);

            file.Dispose();
        }

        public void Serialize<T>(FileStream file, T _obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));

            xml.Serialize(file, _obj);
        }
    }
}
