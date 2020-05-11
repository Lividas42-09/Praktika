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
    /// Логика взаимодействия для Pleer.xaml
    /// </summary>
    public partial class Pleer : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Pleer()
        {
            try
            {
                InitializeComponent();
                logger.Info("Запуск MP3_PLAYER успешен");
            }
            catch
            {
                logger.Error("Запуск MP3_PLAYER провален");
            }
        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Попытка открыть mp3 файл");
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Multiselect = false,
                    DefaultExt = ".mp3"
                };
                bool? dialogOk = fileDialog.ShowDialog();
                if (dialogOk == true)
                {
                    filename = fileDialog.FileName;
                    text1.Text = fileDialog.SafeFileName;
                    mediaPlayer.Open(new Uri(filename));
                    logger.Info("Открытие файла произошло успешно");
                }
            }
            catch
            {
                logger.Error("Запуск MP3_PLAYER провален");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
            logger.Info("Композиция запущена");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
            logger.Info("Композиция поставлена на паузу");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            logger.Info("Композиция остановлена");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            logger.Info("Была нажата кнопка для перехода В главное меню");
        }
    }
}
