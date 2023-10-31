using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToolAPI
{
    internal class TranslateItem
    {
        public Guid Id { get; set; }
        public Dictionary<string, string> Translations { get; set; }
    }
}
