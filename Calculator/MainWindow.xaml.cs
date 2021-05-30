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
    /// 

    public partial class MainWindow : Window
    {
        float result = 0;
        List<float> numbers_operators = new List<float>();
        TextBox result_box = new TextBox();
        public MainWindow()
        {
            InitializeComponent();
            
            
            //TEXTBOX PROPERTIES
            result_box.FontSize = 50;
            result_box.Background = Brushes.SlateGray;
            result_box.Foreground = Brushes.White;
            result_box.VerticalContentAlignment = VerticalAlignment.Center;
            result_box.FontWeight = FontWeights.SemiBold;
            result_box.TextAlignment = TextAlignment.Right;
            result_box.SetValue(Grid.ColumnSpanProperty, 4);
            calculator_grid.Children.Add(result_box);
        }

        public bool FirstNumberIs0()
        {
            if(numbers_operators.First()==0)
            {
                return true;
            }
            return false;
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(0);
            if (this.FirstNumberIs0())
            {
                numbers_operators[0] = 0;
                result_box.Text = 0.ToString();
                numbers_operators.Remove(numbers_operators.First());
            }
            else
            {
                numbers_operators.Add(0);
                result_box.Text += 0.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(1);
            if (this.FirstNumberIs0())
            {
                numbers_operators.Remove(numbers_operators.First());
                result_box.Text=1.ToString();              
            }
            else result_box.Text += 1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(2);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 2.ToString();
            }
            else result_box.Text += 2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(3);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 3.ToString();
            }
            else result_box.Text += 3.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(4);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 4.ToString();
            }
            else result_box.Text += 4.ToString();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(5);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 5.ToString();
            }
            else result_box.Text += 5.ToString();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(6);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 6.ToString();
            }
            else result_box.Text += 6.ToString();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(7);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 7.ToString();
            }
            else result_box.Text += 7.ToString();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(8);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 8.ToString();
            }
            else result_box.Text += 8.ToString();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(9);
            if (this.FirstNumberIs0())
            {
                result_box.Text = 9.ToString();
            }
            else result_box.Text += 9.ToString();
        }


        //OPERATOR FUNCTIONS
        private void Divide_Button_Click(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(96);
        }

        private void Adding_Button_Click(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(97);
        }

        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(98);
        }

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            numbers_operators.Add(99);
        }

        public void GetResult_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var number in numbers_operators)
            {
                Console.WriteLine(number);
            }
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            result_box.Clear();
        }
    }
}
