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

namespace _4333Project
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

        // Обработчик для первой кнопки
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            _4333_Зарифуллина _4333_Зарифуллина = new _4333_Зарифуллина();
            _4333_Зарифуллина.Show();
            this.Close();
        }

        // Обработчик для второй кнопки
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            _4333_Abaev _4333_Abaev = new _4333_Abaev();
            _4333_Abaev.Show();
        }
    }
}
