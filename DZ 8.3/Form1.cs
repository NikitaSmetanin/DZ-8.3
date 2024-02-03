using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DZ_8._3
{
    public partial class Form1 : Form
    {
        DBHelper DBHelper = null;

        public Form1()
        {
            InitializeComponent();
            DBHelper = new DBHelper(port:8889);
        }
        // Функція авторизації існуючого користувача
        private void LoginButton_Click(object sender, EventArgs e)
        {
            DataRowCollection dataRowCollection = UserRepository.getUsers(DBHelper.getMySqlConnection(),
               this.EmailBox.Text.Trim(), this.PasswordBox.Text.Trim());
            
            if (dataRowCollection.Count == 0) {
                MessageBox.Show("Невірний логін або пароль!");
                return; 
            } else
            {
                MessageBox.Show("Користувач знайдений! Вхід успішний!");
            }
        }
        // Функція реєстрації нового користувача
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (this.EmailBox.Text.Trim().Length == 0 || this.NameBox.Text.Trim().Length == 0 || this.PasswordBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заповніть всі необхідні поля!", "Помилка", MessageBoxButtons.OK);
                return;
            }
            
            DataRowCollection dataRowCollection = UserRepository.getUserByEmail(DBHelper.getMySqlConnection(), this.EmailBox.Text.Trim());
            
            if (dataRowCollection.Count != 0)
            {
                MessageBox.Show("Користувач з таким логіном вже існує!");
                return;
            }                     

            UserRepository.createCity(DBHelper.getMySqlConnection(), 
                this.NameBox.Text.Trim(), this.EmailBox.Text.Trim(), this.PasswordBox.Text.Trim());
        }
    }
    // Клас налаштування підключення до бази даних
    public class DBHelper
    {
        private string server = "";
        private int port = 0;
        private string username = "";
        private string password = "";
        private string database = "";

        MySqlConnection mySqlConnection = null;

        public DBHelper(string server = "localhost",
                        int port = 3306,
                        string username = "root",
                        string password = "root",
                        string database = "world")
        {
            mySqlConnection = new MySqlConnection($"server={server};port={port};username={username};password={password};database={database}");
        }

        public MySqlConnection getMySqlConnection()
        {
            return mySqlConnection;
        }
    }
    // Клас репозиторій користувача
    public class UserRepository
    {
        // Функція для отримання даних з бази даних
        private static DataRowCollection GetSelectedData(MySqlCommand mySqlCommand)
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(table);

            return table.Rows;
        }
        // Функція для відбору користувачів з базт даних по емейлу
        public static DataRowCollection getUserByEmail(MySqlConnection mySqlConnection, string email)
        {
            using (MySqlCommand mySqlCommand = new MySqlCommand(
                $"SELECT * " +
                $"FROM user " +
                $"WHERE Email = '{email}'", mySqlConnection))
            {
                return GetSelectedData(mySqlCommand);
            };
        }
        // Функція для відбору користувачів з базі даних по емейлу та паролю
        public static DataRowCollection getUsers(MySqlConnection mySqlConnection, string email, string password)
        {
            using (MySqlCommand mySqlCommand = new MySqlCommand(
                $"SELECT * " +
                $"FROM user " +
                $"WHERE Email = '{email}' AND Password = '{password}'", mySqlConnection))                
            {
                return GetSelectedData(mySqlCommand);
            };
        }
        // Функція додавання користувача в бвзу даних
        public static void createCity(MySqlConnection mySqlConnection, string name, string email, string password)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand($"INSERT INTO user (Name, Email, Password) VALUES (@name,@email,@password)", mySqlConnection);                                
                mySqlCommand.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@name",
                    MySqlDbType = MySqlDbType.VarChar,
                    Value = name
                });
                mySqlCommand.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@email",
                    MySqlDbType = MySqlDbType.VarChar,
                    Value = email
                });
                mySqlCommand.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@password",
                    MySqlDbType = MySqlDbType.VarChar,
                    Value = password
                });
               
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Користувача успішно додано в базу даних!", "Повідомлення");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
