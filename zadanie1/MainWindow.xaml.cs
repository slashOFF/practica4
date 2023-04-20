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

namespace zadanie1
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
                int N = int.Parse(TbNumberN.Text);
                if (N>=1 && N<=12)
                switch (N)
                {
                    case 1:
                        TextBlockAnswer.Text = "31 день";
                        break;
                    case 2:
                        TextBlockAnswer.Text = "28 дней";
                        break;
                    case 3:
                        TextBlockAnswer.Text = "31 день";
                        break;
                    case 4:
                        TextBlockAnswer.Text = "30 дней";
                        break;
                    case 5:
                        TextBlockAnswer.Text = "31 день";
                        break;
                    case 6:
                        TextBlockAnswer.Text = "30 дней";
                        break;
                    case 7:
                        TextBlockAnswer.Text = "31 день";
                        break;
                    case 8:
                        TextBlockAnswer.Text = "31 день";
                        break;
                    case 9:
                        TextBlockAnswer.Text = "30 дней";
                        break;
                    case 10:
                        TextBlockAnswer.Text = "31 день";
                        break;
                    case 11:
                        TextBlockAnswer.Text = "30 дней";
                        break;
                    case 12:
                        TextBlockAnswer.Text = "31 день";
                        break;
                }
                else
                {
                    TextBlockAnswer.Text = "Ошибка";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
