using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Net.Http.Headers;

namespace Calc
{
    public partial class MainWindow : Window
    {
        private string input;
        private int inputint;
        public MainWindow()
        {
            InitializeComponent();

            nol.Click += Nol_Click; 
            two.Click += Two_Click;
            one.Click += One_Click;
            three.Click += Three_Click; 
            four.Click += Four_Click;
            five.Click += Five_Click;
            six.Click += Six_Click; 
            seven.Click += Seven_Click;
            eight.Click += Eight_Click; 
            nine.Click += Nine_Click; 
            dot.Click += Dot_Click;
            c1.Click += C_Click;
            skobka1.Click += Skobka1_Click;
            skobka2.Click += Skobka2_Click; 
            plus.Click += Plus_Click;
            minusodin.Click += Minusodin_Click; 
            ravno.Click += Ravno_Click;
        }

        private void Ravno_Click(object? sender, RoutedEventArgs e)
        {
            if (plus.IsChecked == true)
            {
                /*for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (i != j)
                        {
                            int otvet1 = inputint + inputint;
                        }
                    }
                }*/
                inputint = 0;
            }

        }

        private void Minusodin_Click(object? sender, RoutedEventArgs e)
        {
            //vvod.Text.IndexOf(input) - 1;
        }

        private void Plus_Click(object? sender, RoutedEventArgs e)
        {
            input = "+";
            vvod.Text += input;
        }

        private void Skobka2_Click(object? sender, RoutedEventArgs e)
        {
            input = ")";
            vvod.Text += input;
        }

        private void Skobka1_Click(object? sender, RoutedEventArgs e)
        {
            input = "(";
            vvod.Text += input;
        }

        private void C_Click(object? sender, RoutedEventArgs e)
        {
            vvod.Text = "";
        }

        private void Dot_Click(object? sender, RoutedEventArgs e)
        {             
            input = ".";
            if ((vvod.Text.IndexOf(input) == -1) && (vvod.Text.IndexOf(" ") == -1))
            {
                vvod.Text += input;
            }
        }

        private void Nine_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 9;
            vvod.Text += inputint;
        }

        private void Eight_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 8;
            vvod.Text += inputint;
        }

        private void Seven_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 7;
            vvod.Text += inputint;
        }

        private void Six_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 6;
            vvod.Text += inputint;
        }

        private void Five_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 5;
            vvod.Text += inputint;
        }

        private void Four_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 4;
            vvod.Text += inputint;
        }

        private void Three_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 3;
            vvod.Text += inputint;
        }

        private void One_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 1;
            vvod.Text += inputint;
        }

        private void Two_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 2;
            vvod.Text += inputint;
        }
         
        private void Nol_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 0;
            vvod.Text += inputint;
        }
    }
}