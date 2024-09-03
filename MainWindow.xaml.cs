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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BufferDisplay = "Test text, please ignore( * + - )";
            MainDisplay = 0m;

            this.DataContext = this;
        }

        private string _bufferDisplay;
        public string BufferDisplay
        {
            get { return _bufferDisplay; }
            set { _bufferDisplay = value; }
        }

        private decimal _mainDisplay;
        public decimal MainDisplay
        {
            get { return _mainDisplay; }
            set { _mainDisplay = value; }
        }

        private void ComputationButtonsClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
