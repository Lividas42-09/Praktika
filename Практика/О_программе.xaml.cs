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
using NLog;

namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для О_программе.xaml
    /// </summary>
    public partial class О_программе : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public О_программе()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода В главное меню");
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            catch
            {
                logger.Error("При переходе В главное меню произошла ошибка");
            }
        }
    }
}
