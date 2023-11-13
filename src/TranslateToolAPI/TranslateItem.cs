using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToolAPI
{
    public class TranslateItem
    {
        public uint Id { get; set; }
        public Dictionary<string, string> Translations { get; set; }
    }
}
