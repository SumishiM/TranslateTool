using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tool
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        void AddColumn(string newColumnName)
        {

            this.TranslationGrid.Columns.Add(new DataGridTextColumn
            {
                // bind to a dictionary property
                Binding = new Binding("Custom[" + newColumnName + "]"),
                Header = newColumnName,
                DisplayIndex = TranslationGrid.Columns.Count - 1,

            });
            this.TranslationGrid.Columns[1].DisplayIndex = TranslationGrid.Columns.Count;
        }
    }
}
