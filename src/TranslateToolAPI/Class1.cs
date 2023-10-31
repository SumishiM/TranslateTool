using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToolAPI
{
    public interface ISerializable
    {
        void Serialize<T>(T _obj) ;
        T Deserialize<T>() ;


    }
    public class Class1
    {
    }
}
