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
            {
                logger.Trace("trace message");
                logger.Debug("debug message");
                logger.Info("info message");
                logger.Warn("warn message");
                logger.Error("error message");
                logger.Fatal("fatal message");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Файл файл = new Файл();
            файл.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Настройки настройки = new Настройки();
            настройки.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            О_программе _ = new О_программе();
            _.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Авторизация авторизация = new Авторизация();
            авторизация.Show();
            this.Close();
        }
    }

    
}
