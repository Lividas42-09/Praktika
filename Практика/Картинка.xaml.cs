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
using Microsoft.Win32;
using NLog;

namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для Картинка.xaml
    /// </summary>
    public partial class Картинка : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Картинка()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("Попытка открыть файл");
            StackPanel sp = new StackPanel();
            Image tb = new Image();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                tb.Source = new BitmapImage(new Uri(openDialog.FileName));
                logger.Info("Файл открыт успешно");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {       
            try
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
                logger.Info("Была нажата кнопка по возвращению В главное меню");
            }
            catch
            {
                logger.Error("Операция по возвращеню В главное меню прошла с ошибкой");
            }
        }
    }
}
