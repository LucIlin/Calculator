using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            BufferDisplay = "Test text, please ignore( * + - )";
            _mainDisplay = "0";

            this.DataContext = this;
        }

        private string _bufferDisplay;
        public string BufferDisplay
        {
            get { return _bufferDisplay; }
            set { _bufferDisplay = value; }
        }

        private string _mainDisplay;
        public string MainDisplay
        {
            get { return _mainDisplay; }
            set {
                    if (_mainDisplay != value)
                    {
                        _mainDisplay = value;
                        OnPropertyChanged(nameof(MainDisplay));
                    }
                }
        }


        StringBuilder numberAsString = new StringBuilder();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AppendDigit(char digit)
        {
            numberAsString.Append(digit);
            MainDisplay = numberAsString.ToString();
        }
        private void ComputationButtonsClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    //case "Percent":

                    //    break;
                    //case "Fraction":

                    //    break;
                    case "Seven":
                        AppendDigit('7');
                        break;
                    case "Four":
                        AppendDigit('4');
                        break;
                    case "One":
                        AppendDigit('1');
                        break;
                    //case "Negate":

                    //    break;
                    //case "ClearEntry":

                    //    break;
                    //case "Square":

                    //    break;
                    case "Eight":
                        AppendDigit('8');
                        break;
                    case "Five":
                        AppendDigit('5');
                        break;
                    case "Two":
                        AppendDigit('2');
                        break;
                    case "Zero":
                        AppendDigit('0');
                        break;
                    //case "Clear":

                    //    break;
                    //case "Radical":

                    //    break;
                    case "Nine":
                        AppendDigit('9');
                        break;
                    case "Six":
                        AppendDigit('6');
                        break;
                    case "Three":
                        AppendDigit('3');
                        break;
                    //case "Comma":

                    //    break;
                    //case "Delete":

                    //    break;
                    //case "Divide":

                    //    break;
                    //case "Multiply":

                    //    break;
                    //case "Subtract":

                    //    break;
                    //case "Add":

                    //    break;
                    //case "Equals":

                    //    break;

                }
            }
        }
    }
}
