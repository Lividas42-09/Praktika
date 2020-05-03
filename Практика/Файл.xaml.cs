using Microsoft.Win32;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для Файл.xaml
    /// </summary>
    public partial class Файл : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Файл()
        {
           
            try
            {
                InitializeComponent();
                logger.Info("Запуск открытия конкретного файла успешен");
            }
            catch
            {
                logger.Error("Запуск открытия конкретного файла провален");
                logger.Fatal("Запуск открытия конкретного файла провален фатально");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                logger.Info("Запущена процедура открытия файла");
                try
                {
                    if (openFileDialog.ShowDialog() == true)
                        Text.Text = File.ReadAllText(openFileDialog.FileName);
                    logger.Info("Процедура открытия файла прошла успешно");
                }
                catch
                {
                    logger.Error("Процедура открытия файла провалена");
                }


            } 
            catch
            {
                logger.Error("Процедура открытия файла провалена");
                logger.Fatal("Процедура открытия файла провалена фатально");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Da da = new Da();
            da.Show();
            this.Close();
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
