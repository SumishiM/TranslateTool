using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToolAPI
{
    public class Application
    {
        public static ICollection<TranslateItem> translateItems;

        public static void Initialize()
        {
            translateItems = new List<TranslateItem>();
        }

    }

    
}
