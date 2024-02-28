using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Net.Http.Headers;
using System.Threading;
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
            minus.Click += Minus_Click; 
            multiply.Click += Multiply_Click;  
            div.Click += Div_Click; 
            sqrt.Click += Sqrt_Click;
            sin.Click += Sin_Click;
            cos.Click += Cos_Click; 
            tg.Click += Tg_Click;  
            ctg.Click += Ctg_Click;
            exp.Click += Exp_Click;
            mod.Click += Mod_Click; 
            ostatok.Click += Ostatok_Click;  
            factorial.Click += Factorial_Click;
        }
        private void Factorial_Click(object? sender, RoutedEventArgs e)                //Факториал
        {
            inputint = Convert.ToDouble(vvod.Text);
            int factorial = 1;
            for (int i = 1; i <= inputint; i++)
            {
                factorial *= i;
                if (i == inputint)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} * ", i);
                }
            }
            vvod.Text = $"{factorial}";
        }

        private void Ostatok_Click(object? sender, RoutedEventArgs e)                  //Остаток от деления
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            vvod.Text = $"{inputint}" + "%";
        }

        private void Mod_Click(object? sender, RoutedEventArgs e)                      //mod
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            vvod.Text = $"{inputint}" + "mod";
        }

        private void Exp_Click(object? sender, RoutedEventArgs e)                      //exp
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            vvod.Text = $"{inputint}" + ",e+";
        }

        private void Ctg_Click(object? sender, RoutedEventArgs e)                      //Котангенс (в радианах)
        {
            double i = inputint;
            double cotangens = 1 / Math.Tan(i);
            vvod.Text = Convert.ToString(cotangens);
            inputint = cotangens;
        }

        private void Tg_Click(object? sender, RoutedEventArgs e)                       //Тангенс (в радианах)
        {
            double i = inputint;
            double tangens = Math.Tan(i);
            vvod.Text = Convert.ToString(tangens);
            inputint = tangens;
        }

        private void Cos_Click(object? sender, RoutedEventArgs e)                      //Косинус (в радианах)
        {
            double i = inputint;
            double cosinus = Math.Cos(i);
            vvod.Text = Convert.ToString(cosinus);
            inputint = cosinus;
        }

        private void Sin_Click(object? sender, RoutedEventArgs e)                      //Синус (в радианах)
        {
            double i = inputint;
            double sinus = Math.Sin(i);
            vvod.Text = Convert.ToString(sinus);
            inputint = sinus;
        }

        private void Sqrt_Click(object? sender, RoutedEventArgs e)                     //Корень
        {
            double i = inputint;
            double coren = Math.Sqrt(i);
            vvod.Text = Convert.ToString(coren);
            inputint = coren;
            if (i < 0)
            {
                vvod.Text = "Неверный ввод";
            }
        }

        private void Div_Click(object? sender, RoutedEventArgs e)                      //Деление
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            input = "/";
            vvod.Text = input;
        }

        private void Multiply_Click(object? sender, RoutedEventArgs e)                 //Умножение
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            input = "*";
            vvod.Text = input;
        }

        private void Minus_Click(object? sender, RoutedEventArgs e)                    //Минус
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            input = "-";
            vvod.Text = input;
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
            if (i < 0)
            {
                vvod.Text = "Неверный ввод";
            }
        }

        private void Log_Click(object? sender, RoutedEventArgs e)                      //Логарифм
        {
            double i = inputint; //*
            double ll = Math.Log10(i);
            vvod.Text = Convert.ToString(ll);
            inputint = ll;
            if(i < 0)
            {
                vvod.Text = "Неверный ввод";
            }
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
        }                    //Число пи

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
        }                    //Плюс/минус

        private void Xy_Click(object? sender, RoutedEventArgs e)
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            input = "^";
            vvod.Text = input;           
        }                    //х в степени у

        private void _10x_Click(object? sender, RoutedEventArgs e)
        {
            double i1 = 10;
            double i2 = Convert.ToInt32(inputint);//*
            double _10x = Math.Pow(i1,i2);
            vvod.Text = $"{_10x}";
            inputint = Convert.ToInt32(_10x);
        }                  //10 в степени у

        private void X2_Click(object? sender, RoutedEventArgs e)                       //*
        {
            inputint = Convert.ToDouble(vvod.Text);
            double x2 = inputint * inputint;
            vvod.Text = $"{x2}";
            inputint = x2;
        }

        private void Ravno_Click(object? sender, RoutedEventArgs e)
        {
            if (vvod.Text.Contains('(') && vvod.Text.Contains(')'))
            if (vvod.Text.Contains('^'))
            {
                double stepen = Math.Pow(inputint,inputint2);
                vvod.Text = $"{stepen}";
            }
            if (vvod.Text.Contains('+') == true && vvod.Text.Contains(",e+") == false)
            {
                double plus = inputint + inputint2;
                vvod.Text = $"{plus}";
                
            }
            if (vvod.Text.Contains('-'))
            {
                double minus = inputint - inputint2;
                vvod.Text = $"{minus}";
            }
            if (vvod.Text.Contains('*'))
            {
                double multy = inputint * inputint2;
                vvod.Text = $"{multy}";
            }
            if (vvod.Text.Contains('/'))
            {
                double div = inputint / inputint2;
                vvod.Text = $"{div}";
            }
            if (vvod.Text.Contains(",e+"))
            {
                double i = 10;
                double i2 = Convert.ToInt32(inputint2);
                double i3 = Convert.ToInt32(inputint);
                double expetrum = i2 * (Math.Pow(i,i3));
                vvod.Text = $"{expetrum}";
            }
            if (vvod.Text.Contains("mod"))
            {
                double mod = inputint2 % inputint;
                vvod.Text = $"{mod}";
            }
            if (vvod.Text.Contains('%'))
            {
                double ost = inputint2 % inputint;
                vvod.Text = $"{ost}";
            }
        }                 //Равно

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
        }             //Минус символ

        private void Plus_Click(object? sender, RoutedEventArgs e)
        {
            inputint2 = Convert.ToDouble(vvod.Text);
            input = "+";
            vvod.Text = input;
        }                  //Плюс

        private void Skobka2_Click(object? sender, RoutedEventArgs e)
        {
            input = ")";
            vvod.Text += input;
        }               //Скобка ) вот это вот

        private void Skobka1_Click(object? sender, RoutedEventArgs e)
        {
            input = "(";
            vvod.Text += input;
        }               //Скобка ( и такая вот
         
        private void C_Click(object? sender, RoutedEventArgs e)
        {
            vvod.Text = "";
        }                     //! СБРОС !

        private void Dot_Click(object? sender, RoutedEventArgs e)
        {             
            input = ",";
            if ((vvod.Text.IndexOf(input) == -1) && (vvod.Text.IndexOf(" ") == -1))
            {
                vvod.Text += input;
            }
        }                   //Запятая

        private void Nine_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 9;
            vvod.Text += inputint;
        }                  //Девять

        private void Eight_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 8;
            vvod.Text += inputint;
        }                 //Восемь

        private void Seven_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 7;
            vvod.Text += inputint;
        }                 //Семь

        private void Six_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 6;
            vvod.Text += inputint;
        }                   //Шесть

        private void Five_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 5;
            vvod.Text += inputint;
        }                  //Пять

        private void Four_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 4;
            vvod.Text += inputint;
        }                  //ЧетЫре

        private void Three_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 3;
            vvod.Text += inputint;
        }                 //Т  Р  И

        private void One_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 1;
            vvod.Text += inputint;
        }                   //Д В А

        private void Two_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 2;
            vvod.Text += inputint;
        }                   //ОДИН
       
        private void Nol_Click(object? sender, RoutedEventArgs e)
        {
            inputint = 0;
            vvod.Text += inputint;
        }                   //ноль
    }
}