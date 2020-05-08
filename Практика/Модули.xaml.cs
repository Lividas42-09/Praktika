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
    /// Логика взаимодействия для Настройки.xaml
    /// </summary>
    public partial class Настройки : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Настройки()
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
                logger.Error("Произошла ошибка при попытке перехода В главное меню");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода В плеер");
                
            }
            catch
            {
                logger.Error("Произошла ошибка при попытке перехода В плеер");
            }
        }
    }
}
