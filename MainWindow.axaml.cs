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
        }

        private void Pi_Click(object? sender, RoutedEventArgs e)
        {
            string pi = "3,14159265358980";
            vvod.Text = pi;
            inputint = Convert.ToDouble(pi);
        }                   //����� ��

        private void Pm_Click(object? sender, RoutedEventArgs e)
        {
            input = "-";
            double aa = Convert.ToDouble(input);
            inputint = aa + inputint;
            vvod.Text = Convert.ToString(inputint);
            //input = inputint.ToString();
        }                   //��

        private void Xy_Click(object? sender, RoutedEventArgs e)
        {
            //inputint = Convert.ToDouble(vvod.Text);
            //vvod.Text = "";
            inputint2 = Convert.ToDouble(vvod.Text);

            double i1 = Convert.ToInt32(inputint);            //inputint2
            double i2 = Convert.ToInt32(inputint2);
            double xy = Convert.ToDouble(Math.Pow(i1, i2));

            inputint = xy;
            vvod.Text = Convert.ToString(xy);
            //inputint = Convert.ToInt32(_10x);
        }                   //� � ������� �

        private void _10x_Click(object? sender, RoutedEventArgs e)
        {
            //int _10x = (10 ^ inputint);
            //vvod.Text = $"{inputint2}";
            double i1 = 10;
            double i2 = Convert.ToInt32(inputint);
            double _10x = Convert.ToDouble(Math.Pow(i1,i2));
            vvod.Text = $"{_10x}";
            inputint = Convert.ToInt32(_10x);
        }                 //10 � �����-�� ��� �������

        private void X2_Click(object? sender, RoutedEventArgs e)                      //*
        {
            inputint = Convert.ToDouble(vvod.Text);
            double x2 = inputint * inputint;
            vvod.Text = $"{x2}";
            inputint = x2;
        }

        private void Ravno_Click(object? sender, RoutedEventArgs e)
        {
            /*if (plus.IsChecked == true)
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
                //inputint = 0;
            //}

        }                //�����

        private void Minusodin_Click(object? sender, RoutedEventArgs e)
        {
            //vvod.Text = Convert.ToString(inputint - inputint);
            string i = Convert.ToString(inputint);
            inputint = Convert.ToDouble(i.Remove(i.Length - 1));
            //inputint = Convert.ToDouble(Convert.ToString(inputint).Remove(Convert.ToString(inputint).Length - 1));
            //int i0 = i.Length - 1;
            //i = i.Remove(i0);
            //string otvet = i.Remove(i.Length - 1);
            //inputint = i.Substring(0, i.Length - 1);
            vvod.Text = $"{inputint}";
        }            //����� ������

        private void Plus_Click(object? sender, RoutedEventArgs e)
        {
            //input = "+";
            //vvod.Text += input;
            inputint2 = Convert.ToDouble(vvod.Text);

            //double i1 = Convert.ToInt32(inputint);            //inputint �
            double plus = Convert.ToDouble(inputint + inputint2);

            inputint = plus;
            vvod.Text = Convert.ToString(plus);
        }                 //����                       ������ ����

        private void Skobka2_Click(object? sender, RoutedEventArgs e)
        {
            input = ")";
            vvod.Text += input;
        }              //������ ) ��� ��� ���

        private void Skobka1_Click(object? sender, RoutedEventArgs e)
        {
            input = "(";
            vvod.Text += input;
        }              //������ ( � ����� ���
         
        private void C_Click(object? sender, RoutedEventArgs e)
        {
            vvod.Text = "";
        }                    //! ����� !

        private void Dot_Click(object? sender, RoutedEventArgs e)
        {             
            input = ",";
            if ((vvod.Text.IndexOf(input) == -1) && (vvod.Text.IndexOf(" ") == -1))
            {
                vvod.Text += input;
            }
        }                  //���(�)���

        private void Nine_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 9;
            vvod.Text += inputint;
        }                 //������

        private void Eight_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 8;
            vvod.Text += inputint;
        }                //������

        private void Seven_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 7;
            vvod.Text += inputint;
        }                //����

        private void Six_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 6;
            vvod.Text += inputint;
        }                  //�����

        private void Five_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 5;
            vvod.Text += inputint;
        }                 //����

        private void Four_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 4;
            vvod.Text += inputint;
        }                 //������

        private void Three_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 3;
            vvod.Text += inputint;
        }                //�  �  �

        private void One_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 1;
            vvod.Text += inputint;
        }                  //� � �

        private void Two_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 2;
            vvod.Text += inputint;
        }                  //����
       
        private void Nol_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 0;
            vvod.Text += inputint;
        }                  //����
    }
}