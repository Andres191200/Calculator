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
    //A SIMPLE CALCULATOR WHICH ALLOWS TO DO SIMPLE OPERATIONS :D

    public partial class MainWindow : Window
    {
        bool resulted = false, operators = false, exponential_btn = false, sqrt = false;
        int j, delta_y = 0, i, result_counting = 0, delta_x = 0, exponential_operator = 0;
        List<float> numbers_operators = new List<float>();
        double first_number, result = 0;
        double second_number;
        float index = 0;
        string aux = " ", second_number_aux = " ";

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
            result_box.SetValue(Grid.ColumnSpanProperty, 5);

            result_box.Text = 0.ToString();
            numbers_operators.Add(0);

            calculator_grid.Children.Add(result_box);
        }

        //VALIDATING FUNCTIONS
        public bool ValidateExponentialBtn()
        {
            if(exponential_btn)
            {
                return true;
            }
            return false;
        }

        public bool ExponentialButton(string num)
        {
            if (exponential_btn)
            {
                result_box.Text += $"{num}";
                second_number_aux += num;
                return true;
            }
            return false;
        }

        public bool OperatorSetted()
        {
            if(operators)
            {
                return true;
            }
            return false;
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


        //ADDING NUMBERS WHEN BUTTONS GETS PRESSED
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (this.ExponentialButton("0"))
            { }
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
            else if (this.ExponentialButton("1"))
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
            else if (this.ExponentialButton("2"))
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
            else if (this.ExponentialButton("3"))
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
            else if (this.ExponentialButton("4"))
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
            else if (this.ExponentialButton("5"))
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
            else if (this.ExponentialButton("6"))
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
            else if (this.ExponentialButton("7"))
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
            else if (this.ExponentialButton("8"))
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
            else if (this.ExponentialButton("9"))
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
            if(ValidateExponentialBtn())
            { }
            else if (this.OperatorSetted())
            {
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1);
                result_box.Text = result_box.Text += "%";

                numbers_operators.Remove(numbers_operators.Last());
                numbers_operators.Add(999999999988);
            }
            else if (this.ExponentialOperations())
            { }
            else
            {
                operators = true;
                resulted = false;
                delta_y++;
                result_box.Text += "%";
                numbers_operators.Add(999999999988);
            }
        }

        private void Adding_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateExponentialBtn())
            { }
            else if (this.OperatorSetted())
            {
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1);
                result_box.Text = result_box.Text += "+";

                numbers_operators.Remove(numbers_operators.Last());
                numbers_operators.Add(999999999989);
            }
            else if (this.ExponentialOperations())
            { }
            else
            {
                operators = true;
                resulted = false;
                delta_y++;
                result_box.Text += "+";
                numbers_operators.Add(999999999989);
            }
        }

        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateExponentialBtn())
            { }
            else if (this.OperatorSetted())
            {
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1);
                result_box.Text = result_box.Text += "x";

                numbers_operators.Remove(numbers_operators.Last());
                numbers_operators.Add(999999999990);
            }
            else if (this.ExponentialOperations())
            { }
            else
            {
                operators = true;
                resulted = false;
                delta_y++;
                result_box.Text += "x";
                numbers_operators.Add(999999999990);
            }
        }

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateExponentialBtn())
            { }
            else if (this.OperatorSetted())
            {
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1);
                result_box.Text = result_box.Text += "-";

                numbers_operators.Remove(numbers_operators.Last());
                numbers_operators.Add(999999999991);
            }
            else if (this.ExponentialOperations())
            { }
            else
            {
                operators = true;
                resulted = false;
                delta_y++;
                result_box.Text += "-";
                numbers_operators.Add(999999999991);
            }
        }

        public void GetResult_Button_Click(object sender, RoutedEventArgs e)
        {
            CalculateOperations();
        }

        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
            //RESETING EVERYTHING INCLUDING LIST
            exponential_btn = false;
            operators = false;
            resulted = false;
            result_counting = 0;
            exponential_operator = 0;
            aux = "";
            index = 0;
            delta_x = 0;
            delta_y = 0;
            result_box.Text = 0.ToString();
            first_number = 0;
            second_number=0;
            sqrt = false;

            numbers_operators.Clear();
            numbers_operators.Add(0);

        }

        private void Square_Number_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateExponentialBtn())
            { }
            else
            {
                exponential_operator++;
                delta_y++;
                result_box.Text += "²";
                numbers_operators.Add(999999999992);
            }
        }

        private void Cube_Number_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateExponentialBtn())
            { }
            else
            {
                resulted = true;
                exponential_operator++;
                delta_y++;
                result_box.Text += "³";
                numbers_operators.Add(999999999993);
            }
        }

        private void Mod_Number_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateExponentialBtn())
            { }
            else if (this.OperatorSetted())
            {
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1);
                result_box.Text = result_box.Text += "MOD";

                numbers_operators.Remove(numbers_operators.Last());
                numbers_operators.Add(999999999994);
            }
            else
            {
                operators = true;
                exponential_operator++; //USING EXPONENTIAL COUNTER EVEN TOUGH IT ISN'T AN EXPONENTIAL OPERATOR, JUST IN CASE...
                resulted = false;
                result_box.Text += "MOD";
                numbers_operators.Add(999999999994);
            }
        }
        private void RemoveLast_Button_Click(object sender, RoutedEventArgs e)
        {
            if(ValidateExponentialBtn())   //YOU CAN'T REMOVE "ELEVATED TO" FUNCTION, YOU HAVE TO PRESS "DEL" BUTTON
            { }
            else if (numbers_operators.Count > 1)
            {
                if (numbers_operators.Last() == 999999999996)
                {
                    sqrt = false;
                }
                else if (numbers_operators.Last()== 999999999992 || numbers_operators.Last()== 999999999993)
                {
                    exponential_operator--;
                    delta_y--;
                    resulted = false;
                }
                numbers_operators.Remove(numbers_operators.Last());
                result_box.Text = result_box.Text.Remove(result_box.Text.Length - 1);
            }
            else
            {
                result_box.Text = "0";
                numbers_operators[0] = 0;
            }
        }
        private void Exponential_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.OperatorSetted())
            { }
            else if (this.NoAddNumbersAfterGettingResult())
            { }
            else
            {
                operators = true;
                exponential_btn = true;

                result_box.FontSize = 35;
                result_box.Text += " elevated to ";

                numbers_operators.Add(999999999995);
            }
        }

        public void Square_Root_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.OperatorSetted())
            { }
            else if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (delta_x == 0 && FirstNumberIs0())
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(999999999996);
                operators = true;
                result_box.Text = "√";
                sqrt = true;
            }
            else
            { }
        }

        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.OperatorSetted())
            { }
            else if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (delta_x == 0)
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(9999999999997);
                operators = true;
                result_box.Text = "log";
            }
        }

        private void Sin_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.OperatorSetted())
            { }
            else if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (delta_x==0)
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(999999999998);
                result_box.Text = "Sin ";
            }
        }

        private void Cos_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.OperatorSetted())
            { }
            else if (this.NoAddNumbersAfterGettingResult())
            { }
            else if (delta_x == 0)
            {
                numbers_operators.Remove(numbers_operators.First());
                numbers_operators.Add(999999999999);
                result_box.Text = "Sin ";
            }
        }


        //GETTING FIRST AND SECOND NUMBERS
        public void CalculateOperations()
        {
            sqrt = false;
            operators = false;
            resulted = true;
            for (i = 0; i < numbers_operators.Count(); i++)
            {
                if (numbers_operators[i] >= 0 && numbers_operators[i] <= 9)
                {
                    delta_x++;
                }
                if (numbers_operators[i] >= 999999999988 && numbers_operators[i] <= 999999999999) 
                {                                                                        
                    index = delta_x; //index of the operator. NOTE: delta_y = counts only operator, delta_x = counts everything
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

                    //OPERATOR CODES GOES 999999999988 THROUGH 999999999999
                    if (numbers_operators[(int)index] == 999999999988) 
                    {
                        result = first_number / second_number;
                    }
                    if (numbers_operators[(int)index] == 999999999989)
                    {
                        result = first_number + second_number;
                    }
                    if (numbers_operators[(int)index] == 999999999990)
                    {
                        result = first_number * second_number;
                    }
                    if (numbers_operators[(int)index] == 999999999991)
                    {
                        result = first_number - second_number;
                    }
                    if (numbers_operators[(int)index] == 999999999992)
                    {
                        result = first_number * first_number;
                    }
                    if (numbers_operators[(int)index] == 999999999993)
                    {
                        result = first_number * first_number * first_number ;
                    }
                    if (numbers_operators[(int)index] == 999999999994)
                    {
                        result = first_number % second_number;
                    }
                    if (numbers_operators[(int)index] == 999999999995)
                    {
                        result = Math.Pow(first_number, second_number);
                    }
                    if (numbers_operators[(int)index] == 999999999996)
                    {
                        result = Math.Sqrt(second_number); 
                    }
                    if (numbers_operators[(int)index] == 999999999997)
                    {
                        result = Math.Log(second_number);
                    }
                    if(numbers_operators[(int)index] == 999999999998)
                    {
                        result = Math.Sin(second_number);
                    }
                    if(numbers_operators[(int)index]== 999999999999)
                    {
                        result = Math.Cos(second_number);
                    }
                }
            }
            result_box.Text = result.ToString();
            result_counting++;

            //CLEANING VARIABLES FOR NEXT OPERATIONS (RESETING VARIABLES...)
            delta_x = 0;
            aux = "";
            exponential_operator = 0;
            exponential_btn = false;
            resulted = false;
            second_number_aux = "";

            numbers_operators.Clear();
            numbers_operators.Add((float)result);
        }
    }
}
