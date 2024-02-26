using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Net.Http.Headers;
using Tmds.DBus.Protocol;

namespace Calc
{
    public partial class MainWindow : Window
    {
        private string? input;
        private double inputint;
        private double inputint2;

        //private int chislo;
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
            x2.Click += X2_Click;
            _10x.Click += _10x_Click;  
            xy.Click += Xy_Click; 
            pm.Click += Pm_Click;
            pi.Click += Pi_Click;
            modul.Click += Modul_Click;  
            _1x.Click += _1x_Click;
            log.Click += Log_Click;
            ln.Click += Ln_Click; 
            e.Click += E_Click;
        }

        private void E_Click(object? sender, RoutedEventArgs e)
        {
            string _e = "2,718281828459045235360";
            vvod.Text = _e;
            inputint = Convert.ToDouble(_e);
        }                     //е

        private void Ln_Click(object? sender, RoutedEventArgs e)                       //Логарифм натуральный
        {
            double i = inputint; //*
            double lll = Math.Log(i);
            vvod.Text = Convert.ToString(lll);
            inputint = lll;
        }

        private void Log_Click(object? sender, RoutedEventArgs e)                      //Логарифм
        {
            double i = inputint; //*
            double ll = Math.Log10(i);
            vvod.Text = Convert.ToString(ll);
            inputint = ll;
        }

        private void _1x_Click(object? sender, RoutedEventArgs e)                      //Один делить на x
        {
            double i1 = 1;
            double i2 = Convert.ToInt32(inputint);//*
            double _1x = i1 / i2;
            vvod.Text = _1x.ToString();
            inputint = _1x;
        }

        private void Modul_Click(object? sender, RoutedEventArgs e)                    //Модули
        {
            if (inputint >= 0)
            {
                vvod.Text = inputint.ToString();
            }
            else
            {
                string i = Convert.ToString(inputint);
                i = i[1..];
                vvod.Text = i;
                inputint = Convert.ToDouble(i);
            }
        }

        private void Pi_Click(object? sender, RoutedEventArgs e)
        {
            string pi = "3,14159265358980";
            vvod.Text = pi;
            inputint = Convert.ToDouble(pi);
        }                   //Число пи

        private void Pm_Click(object? sender, RoutedEventArgs e)
        {
            if (inputint < 0)
            {
                string i = Convert.ToString(inputint);
                i = i[1..];
                vvod.Text = i;
                inputint = Convert.ToDouble(i);
            }
            else
            {
                input = "-";
                string aa = input + inputint;//*
                vvod.Text = aa;
                inputint = Convert.ToDouble(aa);
            }
        }                   //Плюс-минус

        private void Xy_Click(object? sender, RoutedEventArgs e)
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            //vvod.Text = "";
            input = "^";
            //string x_y = inputint + input + inputint2;
            vvod.Text += input;
            //vvod.Text = "";
            //inputint2 = Convert.ToDouble(vvod.Text);
            //inputint2 = 3;
            vvod.Text += inputint2;
            //Ravno_Click(sender, e);
            /*inputint2 = Convert.ToDouble(vvod.Text);

            double i1 = Convert.ToInt32(inputint);            //inputint2
            double i2 = Convert.ToInt32(inputint2);
            double xy = Convert.ToDouble(Math.Pow(i1, i2));

            inputint = xy;
            vvod.Text = Convert.ToString(xy);*/
            //inputint = Convert.ToInt32(_10x);
        }                   //х в степени у

        private void _10x_Click(object? sender, RoutedEventArgs e)
        {
            //int _10x = (10 ^ inputint);
            //vvod.Text = $"{inputint2}";
            double i1 = 10;
            double i2 = Convert.ToInt32(inputint);//*
            double _10x = Math.Pow(i1,i2);
            vvod.Text = $"{_10x}";
            inputint = Convert.ToInt32(_10x);
        }                 //10 в какой-то там степени

        private void X2_Click(object? sender, RoutedEventArgs e)                      //*
        {
            inputint = Convert.ToDouble(vvod.Text);
            double x2 = inputint * inputint;
            vvod.Text = $"{x2}";
            inputint = x2;
        }

        private void Ravno_Click(object? sender, RoutedEventArgs e)
        {
            if (vvod.Text.Contains('^'))
            {
                //double i2 = Convert.ToDouble(inputint2);
                //double i1 = Convert.ToInt32(inputint); //*
                //vvod.Text = "";
                //double i2 = Convert.ToInt32(inputint2); //*
                //vvod.Text += inputint2;
                double jok = Math.Pow(inputint,inputint2);
                vvod.Text = $"{jok}";
            }
        }                //РАВно

        private void Minusodin_Click(object? sender, RoutedEventArgs e)
        {
            //vvod.Text = Convert.ToString(inputint - inputint);
            //string i = Convert.ToString(inputint);
            // i = i
            //inputint = Convert.ToDouble(i.Remove(i.Length - 1));
            //inputint = Convert.ToDouble(Convert.ToString(inputint).Remove(Convert.ToString(inputint).Length - 1));
            //int i0 = i.Length - 1;
            //i = i.Remove(i0);
            //string otvet = i.Remove(i.Length - 1);
            //inputint = i.Substring(0, i.Length - 1);
            //vvod.Text = $"{inputint}";
            string i = Convert.ToString(inputint);
            //var indexLast = new Index(1, fromEnd: true);
            //i = i[1..];
            vvod.Text = i.Remove(i.Length-1);
            inputint = Convert.ToDouble(i);
        }            //Минус символ

        private void Plus_Click(object? sender, RoutedEventArgs e)
        {
            //input = "+";
            //vvod.Text += input;
            inputint2 = Convert.ToDouble(vvod.Text);

            //double i1 = Convert.ToInt32(inputint);            //inputint л
            double plus = Convert.ToDouble(inputint + inputint2);

            inputint = plus;
            vvod.Text = Convert.ToString(plus);
        }                 //Плюс                       просто плюс

        private void Skobka2_Click(object? sender, RoutedEventArgs e)
        {
            input = ")";
            vvod.Text += input;
        }              //Скобка ) вот это вот

        private void Skobka1_Click(object? sender, RoutedEventArgs e)
        {
            input = "(";
            vvod.Text += input;
        }              //Скобка ( и такая вот
         
        private void C_Click(object? sender, RoutedEventArgs e)
        {
            vvod.Text = "";
        }                    //! СБРОС !

        private void Dot_Click(object? sender, RoutedEventArgs e)
        {             
            input = ",";
            if ((vvod.Text.IndexOf(input) == -1) && (vvod.Text.IndexOf(" ") == -1))
            {
                vvod.Text += input;
            }
        }                  //ЗАП(я)тая

        private void Nine_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 9;
            vvod.Text += inputint;
        }                 //Девять

        private void Eight_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 8;
            vvod.Text += inputint;
        }                //Восемь

        private void Seven_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 7;
            vvod.Text += inputint;
        }                //Семь

        private void Six_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 6;
            vvod.Text += inputint;
        }                  //Шесть

        private void Five_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 5;
            vvod.Text += inputint;
        }                 //Пять

        private void Four_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 4;
            vvod.Text += inputint;
        }                 //ЧетЫре

        private void Three_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 3;
            vvod.Text += inputint;
        }                //Т  Р  И

        private void One_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 1;
            vvod.Text += inputint;
        }                  //Д В А

        private void Two_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 2;
            vvod.Text += inputint;
        }                  //ОДИН
       
        private void Nol_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 0;
            vvod.Text += inputint;
        }                  //ноль
    }
}