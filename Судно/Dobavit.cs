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
    public partial class Dobavit : Form
    {
        MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter;
        public Dobavit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(string.Format("INSERT INTO информ VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', {6}, {7}, '{8}', {9}, {10});",
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        textBox4.Text,
                        textBox5.Text,
                        textBox6.Text,
                        textBox7.Text,
                        textBox8.Text,
                        textBox9.Text,
                        textBox10.Text,
                        int.Parse(textBox10.Text) * 12 / 100), Form1.conn);

            try
            {
                mySqlDataAdapter.Fill(dataTable);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
