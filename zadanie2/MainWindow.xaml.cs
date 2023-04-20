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

namespace zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int y = int.Parse(TbNumberV.Text);
                if ((y >= 20) && (y <= 69))
                {
                    switch (y / 10)
                    {
                        case 2:
                            TextBlockAnswer.Text = "двадцать ";
                            break;
                        case 3:
                            TextBlockAnswer.Text = "тридцать ";
                            break;
                        case 4:
                            TextBlockAnswer.Text = "сорок ";
                            break;
                        case 5:
                            TextBlockAnswer.Text = "пятдесят ";
                            break;
                        case 6:
                            TextBlockAnswer.Text = "шестьдесят ";
                            break;
                    }

                    switch (y % 10)
                    {
                        case 1:
                            TextBlockAnswer.Text += "один";
                            break;
                        case 2:
                            TextBlockAnswer.Text += "два";
                            break;
                        case 3:
                            TextBlockAnswer.Text += "три";
                            break;
                        case 4:
                            TextBlockAnswer.Text += "четыре";
                            break;
                        case 5:
                            TextBlockAnswer.Text += "пять";
                            break;
                        case 6:
                            TextBlockAnswer.Text += "шесть";
                            break;
                        case 7:
                            TextBlockAnswer.Text += "семь";
                            break;
                        case 8:
                            TextBlockAnswer.Text += "восемь";
                            break;
                        case 9:
                            TextBlockAnswer.Text += "девять";
                            break;
                    }

                    switch (y % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            TextBlockAnswer.Text += " лет";
                            break;
                        case 1:
                            TextBlockAnswer.Text += " год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            TextBlockAnswer.Text += " года";
                            break;
                    }
                }
                else
                {
                    TextBlockAnswer.Text = "Ошибка";
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}