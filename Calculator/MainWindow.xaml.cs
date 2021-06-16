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
        bool resulted = false;
        int j, delta_y = 0, i, result_counting = 0, delta_x = 0, exponential_operator = 0;
        List<float> numbers_operators = new List<float>();
        double first_number, result = 0;
        double second_number;
        float index = 0;
        string aux = " ";

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
            if (numbers_operators.First() == 0)
            {
                return true;
            }
            return false;
        }

        public bool NoAddNumbersAfterGettingResult()
        {
            if (resulted == true)
            {
                result_box.Text += "";
                return true;
            }
            return false;
        }

        public bool ExponentialOperations()
        {
            if (exponential_operator == 1)
            {
                result_box.Text += "";
                return true;
            }
            else return false;
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (!this.FirstNumberIs0())
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
            if (this.ExponentialOperations())
            { }
            else
            {
                resulted = false;
                delta_y++;
                result_box.Text += "%";
                numbers_operators.Add(96);
            }
        }

        private void Adding_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ExponentialOperations())
            { }
            else
            {
                resulted = false;
                delta_y++;
                result_box.Text += "+";
                numbers_operators.Add(97);
            }
        }

        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ExponentialOperations())
            { }
            else
            {
                resulted = false;
                delta_y++;
                result_box.Text += "x";
                numbers_operators.Add(98);
            }
        }

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ExponentialOperations())
            { }
            else
            {
                resulted = false;
                delta_y++;
                result_box.Text += "-";
                numbers_operators.Add(99);
            }
        }

        public void GetResult_Button_Click(object sender, RoutedEventArgs e)
        {
            CalculateOperations();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            //RESETING EVERYTHING INCLUDING LIST
            resulted = false;
            result_counting = 0;
            exponential_operator = 0;
            aux = "";
            index = 0;
            delta_x = 0;
            numbers_operators.Clear();
            numbers_operators.Add(0);
            delta_y = 0;
            result_box.Text = 0.ToString();
        }

        private void Square_Number_Button(object sender, RoutedEventArgs e)
        {
            if (this.ExponentialOperations())
            { }
            else
            {
                resulted = true;
                exponential_operator++;
                delta_y++;
                result_box.Text += "²";
                numbers_operators.Add(95);
            }
        }

        private void Cube_Number_Button(object sender, RoutedEventArgs e)
        {
            resulted = true;
            exponential_operator++;
            delta_y++;
            result_box.Text += "³";
            numbers_operators.Add(94);
        }

        private void Mod_Number_Button(object sender, RoutedEventArgs e)
        {
            exponential_operator++; //USING EXPONENTIAL COUNTER EVEN TOUGH IT ISN'T AN EXPONENTIAL OPERATOR, JUST IN CASE...
            resulted = false;
            result_box.Text += "MOD";
            numbers_operators.Add(93);
        }

        private void RemoveLast_Button(object sender, RoutedEventArgs e)
        {
            if (result_counting >= 1)
            { }
            else
            {
                numbers_operators.Remove(numbers_operators.Last());
                result_box.Text.Remove(result_box.Text.Length - 1);
                if (result_box.Text == "")
                {
                    result_box.Text = "0";
                    numbers_operators[0] = 0;
                }
            }
        }

        public void CalculateOperations()
        {
            resulted = true;
            for (i = 0; i < numbers_operators.Count(); i++)
            {
                if (numbers_operators[i] >= 0 && numbers_operators[i] <= 9)
                {
                    delta_x++;
                }
                if (numbers_operators[i] >= 93 && numbers_operators[i] <= 99) //96=DIVIDE OPERATOR 98=MULTIPLY OPERATOR
                {                                                             //97=ADD OPERATOR    99=SUBSTRACT OPERATOR
                    index = delta_x; //index of the operator             NOTE: delta_y = counts only operator, delta_x = counts everything
                    delta_x++;
                    for (i = 0; i < index; i++)
                    {
                        aux += numbers_operators[i].ToString();     //GET FIRST NUMBER
                        first_number = Convert.ToDouble(aux);
                    }
                    if (result_counting >= 1)
                    {
                        first_number = result;
                    }

                    aux = "";  //CLEANING AUX VARIABLE FOR THE SECOND NUMBER...

                    for (j = Convert.ToInt32(index + 1); j < numbers_operators.Count(); j++)   //GET SECOND NUMBER
                    {
                        aux += numbers_operators[j].ToString();
                        second_number = Convert.ToDouble(aux);
                    }

                    if (numbers_operators[i] == 93)
                    {
                        result = first_number % second_number;
                    }
                    if (numbers_operators[i] == 94)
                    {
                        result = first_number * first_number * first_number;
                    }
                    if (numbers_operators[i] == 95)
                    {
                        result = first_number * first_number;
                    }
                    if (numbers_operators[i] == 96)
                    {
                        result = first_number / second_number;
                    }
                    if (numbers_operators[i] == 97)
                    {
                        result = first_number + second_number;
                    }
                    if (numbers_operators[i] == 98)
                    {
                        result = first_number * second_number;
                    }
                    if (numbers_operators[i] == 99)
                    {
                        result = first_number - second_number;
                    }

                }
            }

            result_box.Text = result.ToString();
            result_counting++;

            //CLEANING VARIABLES FOR NEXT OPERATIONS
            delta_x = 1;
            aux = "";
            exponential_operator = 0;

            numbers_operators.Clear();
            numbers_operators.Add((float)result);
        }
    }
}
