using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToolAPI
{
    public interface ISerializable
    {
        void Serialize<T>(string path, T _obj);
        void Serialize<T>(FileStream file, T _obj);

        T Deserialize<T>(string path);
        T Deserialize<T>(FileStream file);

    }
    public class Class1
    {
    }
}