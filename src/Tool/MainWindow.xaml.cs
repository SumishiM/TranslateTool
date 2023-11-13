using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TranslateToolAPI;

namespace Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TranslateItem> items;

        public MainWindow()
        {
            InitializeComponent();

            items = new ObservableCollection<TranslateItem>();

            foreach (var item in TranslateToolAPI.Application.translateItems)
            {
                items.Add(item);
            }
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
