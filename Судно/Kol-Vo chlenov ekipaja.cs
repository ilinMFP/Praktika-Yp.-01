using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Судно
{
    public partial class Kol_Vo_chlenov_ekipaja : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=судоходство");
        private MySqlCommand command;
        private MySqlDataAdapter adapter;

        public Kol_Vo_chlenov_ekipaja()
        {
            InitializeComponent();
            command = new MySqlCommand("SELECT * FROM `кол-во экипаж всех судов`", connection);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Kol_Vo_chlenov_ekipaja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
