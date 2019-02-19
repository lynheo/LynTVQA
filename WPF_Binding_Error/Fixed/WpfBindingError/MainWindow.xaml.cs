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

namespace WpfBindingError
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class Data
    {
        public string HelloText { get; set; } = "Hello World!!";
    }

    public partial class MainWindow : Window
    {
        public Data ViewModel { get; set; }
        public MainWindow()
        {
            ViewModel = new Data();
            InitializeComponent();            
        }
    }
}
