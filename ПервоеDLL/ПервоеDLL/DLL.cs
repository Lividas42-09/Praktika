using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xceed.Wpf.Toolkit;
using Habanero.Faces.Base;
using Catel.Services;
using System.Windows;

namespace ПервоеDLL
{
    public class Class1
    {
        public static class DBConnectionService
        {
            private static string ConnectionString { get; set; } = "";
            private static SqlConnection Connection { get; set; } = new SqlConnection();

            public static bool SetSqlConnection(string connectionString)
            {
                ConnectionString = connectionString;
                Connection.ConnectionString = ConnectionString;
                if (!IsSqlConnectionWorks())
                {
                    Connection.ConnectionString = "";
                    return false;
                }
                return true;
            }

            private static void ParseError(string message)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show(message, "Error", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // Yes code here
                }
                else if (result == MessageBoxResult.No)
                { 
                    // No code here
                }
            }

            private static void OpenConnection()
            {
                Connection.Open();
            }

            private static void CloseConnection(bool dispose = false)
            {
                Connection.Close();
                if (dispose)
                {
                    Connection.Dispose();
                }
            }

            public static bool IsSqlConnectionWorks()
            {
                try
                {
                    OpenConnection();
                    CloseConnection();
                    return true;
                }
                catch (Exception exc)
                {
                    ParseError(exc.Message);
                    CloseConnection();
                    return false;
                }
            }

            public static int? SendCommandToSqlServer(string command)
            {
                try
                {
                    OpenConnection();
                    SqlCommand sqlCommand = new SqlCommand(command, Connection);
                    int rowsCount = sqlCommand.ExecuteNonQuery();
                    CloseConnection();
                    return rowsCount;
                }
                catch (Exception exc)
                {
                    ParseError(exc.Message);
                    CloseConnection();
                    return null;
                }
            }

            public static List<string[]> SendQueryToSqlServer(string command)
            {
                try
                {
                    OpenConnection();
                    SqlCommand sqlCommand = new SqlCommand(command, Connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    List<string[]> list = new List<string[]>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int count = reader.FieldCount;
                            string[] array = new string[count];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                array[i] = reader[i].ToString();
                            }
                            list.Add(array);
                        }
                    }
                    reader.Close();
                    CloseConnection();
                    return list;
                }
                catch (Exception exc)
                {
                    ParseError(exc.Message);
                    CloseConnection();
                    return null;
                }
            }

            public static object SendScalarQueryToSqlServer(string command)
            {
                try
                {
                    OpenConnection();
                    SqlCommand sqlCommand = new SqlCommand(command, Connection);
                    object data = sqlCommand.ExecuteScalar();
                    CloseConnection();
                    return data;
                }
                catch (Exception exc)
                {
                    ParseError(exc.Message);
                    CloseConnection();
                    return null;
                }
            }
        }
    }
}
