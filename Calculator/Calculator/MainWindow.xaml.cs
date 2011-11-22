using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics.Contracts;

namespace Calculator
{
    public delegate void OperationHandler(Operation o);

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _displayValueIsResult;
        private bool _comma;


        public MainWindow()
        {
            InitializeComponent();
            this._displayValueIsResult = true;
            _comma = false;
        }

        public event OperationHandler OperationCalled;

        public void SetValueRead()
        {
            _displayValueIsResult = true;
        }

        public double DisplayValue
        {
            get
            {
                return Double.Parse(display.Text);
            }
            set
            {
                display.Text = value.ToString();
                this._displayValueIsResult = true;
            }
        }

        public string StoreIndex
        {
            get
            {
                return StoreCombobox.SelectedItem.ToString();
            }
        }

        protected void OnOperationCalled(Operation o)
        {
            if (this.OperationCalled != null)
            {
                this.OperationCalled(o);
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Recall);
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Enter);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Division);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Addition);
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Subtraction);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Multiplication);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(1);
        }

        private void numberClicked(uint num)
        {
            if (this._displayValueIsResult)
            {
                display.Text = "";
                this._displayValueIsResult = false;
            }
            display.Text += num.ToString();
            if (display.Text.Equals("0")) this._displayValueIsResult = true;
        }

        private void CommaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_comma)
            {
                display.Text += ",";
                _comma = true;
            }
        }

        private void Number2_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(2);
        }

        private void Number3_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(3);
        }

        private void Number4_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(4);
        }

        private void Number5_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(5);
        }

        private void Number6_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(6);
        }

        private void Number7_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(7);
        }

        private void Number8_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(8);
        }

        private void Number9_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(9);
        }

        private void Number0_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(0);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnOperationCalled(Operation.Store);
        }

    }
}
