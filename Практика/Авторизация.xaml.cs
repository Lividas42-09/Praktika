using Habanero.Faces.Base;
using Microsoft.Win32;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
using static ПервоеDLL.Class1;


namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для Авторизация.xaml
    /// </summary>
    public partial class Авторизация : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Была нажата кнопка для перехода В главное меню'");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
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
                logger.Info("Процедура открытия файла была успешна");
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                    Text1.Text = File.ReadAllText(openFileDialog.FileName);
            }
            catch
            {
                logger.Error("Процедура открытия файла была проведена с ошибкой");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string datasourse = TextBox1.Text;
            string database = TextBox2.Text;
            string username = TextBox3.Text ?? "";
            string userpass = TextBox4.Text ?? "";
            
           
                if (string.IsNullOrEmpty(datasourse) || string.IsNullOrEmpty(database))
                {
                    MessageBox.Show("Ошибка! Не все поля заполнены.", "Ошибка соединения", MessageBoxButton.OK);
                    return;
                }
                logger.Error("Процедура подключения к БД была проведена с ошибкой");
            
                if (DBConnectionService.SetSqlConnection(GetDBConnectionString(datasourse, database, username, userpass)))
                {
                    MessageBox.Show("Выполнен!", "Соединение подключено", MessageBoxButton.OK);
                }
                logger.Info("Процедура подключения к БД была проведена успешно");
            
        }

        private string GetDBConnectionString(string datasourse, string database, string username, string password)
        {
            string dataSourceStirng = "Data Source=" + datasourse + ";Initial Catalog=" + database + ";Persist Security Info=True;";
            if (!string.IsNullOrEmpty(username))
            {
                dataSourceStirng += "User ID=" + username + ";Password=" + password + ";";
            }
            else
            {
                dataSourceStirng += "Integrated Security=SSPI;";
            }
            return dataSourceStirng;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Процедура очистки файла была успешна");
                Text1.Clear();
            }
            catch
            {
                logger.Error("Процедура очистки файла была проведена с ошибкой");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Процедура очистки полей ввода была успешна");
                TextBox1.Clear();
                TextBox2.Clear();
                TextBox3.Clear();
                TextBox4.Clear();
            }
            catch
            {
                logger.Error("Процедура очистки полей ввода была проведена с ошибкой");
            }
        }
    }
}
