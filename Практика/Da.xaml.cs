using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для Da.xaml
    /// </summary>
    public partial class Da : Window
    {
        public Da()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Da no = new Da();
            no.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Файл da = new Файл();
            da.Show();
            this.Close();
        }
    }
}
