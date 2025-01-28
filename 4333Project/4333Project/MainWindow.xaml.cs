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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _4333_Зарифуллина _4333_Зарифуллина = new _4333_Зарифуллина();
            _4333_Зарифуллина.Show();
            this.Close();
        }

        private void ButtonDana_Click(object sender, RoutedEventArgs e)
        {
            _4333_Хакимуллина _4333_Хакимуллина = new _4333_Хакимуллина();
            _4333_Хакимуллина.Show();
        }
    }
}
