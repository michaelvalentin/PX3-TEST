using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    using System.Diagnostics.Contracts;

    public delegate void Handler(Operation o);

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _valueIsResult;
        private bool _comma;


        public MainWindow()
        {
            InitializeComponent();
            _valueIsResult = true;
            _comma = false;
        }

        public event Handler CollectionChange;

        public double GetValue()
        {
            return Double.Parse(display.Text);
        }

        protected void OnCollectionChange(Operation o)
        {
            if (this.CollectionChange != null)
            {
                this.CollectionChange(o);
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnCollectionChange(Operation.Division);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnCollectionChange(Operation.Addition);
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnCollectionChange(Operation.Subtraction);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            this.OnCollectionChange(Operation.Multiplication);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.numberClicked(1);
        }

        private void numberClicked(uint num)
        {
            if (_valueIsResult)
            {
                display.Text = "";
                _valueIsResult = false;
            }
            display.Text += num.ToString();
            if (display.Text.Equals("0")) _valueIsResult = true;
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
            display.Text = display.Text.Substring(0, display.Text.Length - 1);
        }

    }
}
