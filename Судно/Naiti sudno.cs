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
    public partial class Naiti_sudno : Form
    {
        public static DataTable dt;
        public Naiti_sudno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter
                (string.Format("SELECT `Фамилия капитана`, `Наименование`, `Тип`, `Время рейса, мес.` FROM `информ` WHERE `Фамилия капитана` = '{0}'", textBox1.Text), Form1.conn);
            dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            Naiti_sudno2 naiti_Sudno2 = new Naiti_sudno2();
            naiti_Sudno2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
