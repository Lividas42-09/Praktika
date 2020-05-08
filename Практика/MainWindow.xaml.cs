using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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


namespace Практика
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода на форму 'Файл'");
                Файл файл = new Файл();
                файл.Show();
                this.Close();
            }
            catch
            {
                logger.Error("Произошла ошибка при попытке перехода на форму 'Файл'");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода на форму 'Модули'");
                Настройки настройки = new Настройки();
                настройки.Show();
                this.Close();
            }
            catch
            {
                logger.Error("Произошла ошибка при попытке перехода на форму 'Модули'");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода на форму 'О программе'");
                О_программе _ = new О_программе();
                _.Show();
                this.Close();
            }
            catch
            {
                logger.Error("Произошла ошибка при попытке перехода на форму 'О программе'");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода на форму 'Авторизация'");
                Авторизация авторизация = new Авторизация();
                авторизация.Show();
                this.Close();
            }
            catch
            {
                logger.Error("Произошла ошибка при попытке перехода на форму 'Авторизация'");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Программа была успешна закрыта");
                this.Close();
            }
            catch
            {
                logger.Error("При закрытии произошла ошибка");
            }
        }
    }

    
}
