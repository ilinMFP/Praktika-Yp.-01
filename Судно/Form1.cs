using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Судно
{
    public partial class Form1 : Form
    {
        public static MySql.Data.MySqlClient.MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=судоходство");
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private bool ValidateUser(string username, string password)
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=root;database=судоходство";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE user = @username AND password = @pass AND role = 'admin'";
                if (username == "rer")
                {
                    query = "SELECT COUNT(*) FROM users WHERE user = @username AND password = @pass AND role = 'user'";
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Вход выполнен успешно!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

               
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
