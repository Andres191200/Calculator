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
        int j;
        float result = 0;
        List<float> numbers_operators = new List<float>();
        double first_number;
        double second_number;
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

            result_box.Text = 0.ToString();
            numbers_operators.Add(0);

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
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(0);
                result_box.Text += 0.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(1);
                result_box.Text += 1.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(1);
                result_box.Text = 1.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(2);
                result_box.Text += 2.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(2);
                result_box.Text = 2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(3);
                result_box.Text += 3.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(3);
                result_box.Text = 3.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(4);
                result_box.Text += 4.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(4);
                result_box.Text = 4.ToString();
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(5);
                result_box.Text += 5.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(5);
                result_box.Text = 5.ToString();
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(6);
                result_box.Text += 6.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(6);
                result_box.Text = 6.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(7);
                result_box.Text += 7.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(7);
                result_box.Text = 7.ToString();
            }
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(8);
                result_box.Text += 8.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(8);
                result_box.Text = 8.ToString();
            }
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (!this.FirstNumberIs0())
            {
                numbers_operators.Add(9);
                result_box.Text += 9.ToString();
            }
            else
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(9);
                result_box.Text = 9.ToString();
            }
        }


        //OPERATOR FUNCTIONS
        private void Divide_Button_Click(object sender, RoutedEventArgs e)
        {
            result_box.Text += "%";
            numbers_operators.Add(96);
        }

        private void Adding_Button_Click(object sender, RoutedEventArgs e)
        {
            result_box.Text += "+";
            numbers_operators.Add(97);
        }

        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            result_box.Text += "x";
            numbers_operators.Add(98);
        }

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            result_box.Text += "-";
            numbers_operators.Add(99);
        }

        public void GetResult_Button_Click(object sender, RoutedEventArgs e)
        {
            CalculateOperations();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            numbers_operators.Clear();
            numbers_operators.Add(0);
            result_box.Text = 0.ToString();
        }

        public void CalculateOperations()
        {
            int delta_x = 0, delta_y = 0;
            float index = 0;
            double result = 0;
            string aux = " ";


            foreach (float number in numbers_operators)
            {
                if (number >= 0 && number <= 9)
                {
                    delta_x++;
                }
                if (number >= 96 && number <= 99) //96=DIVIDE OPERATOR 98=MULTIPLY OPERATOR
                {                            //97=ADD OPERATOR    99=SUBSTRACT OPERATOR
                    delta_y++;
                    index = delta_x; //index of "%"
                    delta_x++;
                    if (number == 96)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            aux += numbers_operators[i].ToString();     //GET FIRST NUMBER
                            first_number = Convert.ToDouble(aux);
                        }
                    }                    
                    
                    aux = "";  //CLEANING AUX VARIABLE FOR THE SECOND NUMBER...              
                    for (j = Convert.ToInt32(index+1); j < numbers_operators.Count(); j++)   //GET SECOND NUMBER
                    {
                        aux += numbers_operators[j].ToString();
                        second_number = Convert.ToDouble(aux);
                    }

                    result_box.Clear();
                    result = first_number / second_number;
                    result_box.Text = (" "+result);
                    
                }
            }
                
            
        }
    }
}
