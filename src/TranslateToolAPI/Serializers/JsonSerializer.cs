using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TranslateToolAPI
{
    public sealed class JsonSerializer : ISerializer
    {
        public T Deserialize<T>(string path)
        {
            T result = JsonConvert.DeserializeObject<T>(path);
            return result;
        }

        public T Deserialize<T>(FileStream file)
        {
            byte[] json = new byte[file.Length];
            file.Read(json, 0, (int)file.Length);
            T result = JsonConvert.DeserializeObject<T>(UTF8Encoding.UTF8.GetString(json));
            return result;
        }

        public void Serialize<T>(string path, T _obj)
        {
            string json = JsonConvert.SerializeObject(_obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public void Serialize<T>(FileStream file, T _obj)
        {
            string json = JsonConvert.SerializeObject(_obj, Formatting.Indented);
            file.Position = 0;
            file.Write(UTF8Encoding.UTF8.GetBytes(json), 0, json.Length);
            file.SetLength(json.Length);
        }
    }
}
