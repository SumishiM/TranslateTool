using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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
    /// Logique d'interaction pour ToolBar.xaml
    /// </summary>
    public partial class ToolBar : UserControl
    {
        public ToolBar()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New");
        }
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }
        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }
        private void mnuSaveAs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save As");
        }
        public void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
