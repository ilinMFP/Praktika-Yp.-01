using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Судно
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=судоходство");
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        public Form2()
        {
            InitializeComponent();
            command = new MySqlCommand("SELECT * FROM `glavnoe`", connection);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выход выполнен успешно!");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            God_Cudno god_Cudno = new God_Cudno();
            god_Cudno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Naib_Vod naib_Vod = new Naib_Vod();
            naib_Vod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kol_Vo_chlenov_ekipaja kol_Vo_Chlenov_Ekipaja = new Kol_Vo_chlenov_ekipaja();
            kol_Vo_Chlenov_Ekipaja.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Sortirovka sortirovka = new Sortirovka();
            sortirovka.Show();
        }

       private void button4_Click(object sender, EventArgs e)
        {
           Naiti_sudno naiti_Sudno = new Naiti_sudno();
           naiti_Sudno.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Dobavit dobavit = new Dobavit();
           dobavit.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Udal udal = new Udal();
            udal.Show();
        }
    }
}
