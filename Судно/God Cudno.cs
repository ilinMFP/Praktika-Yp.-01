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
    public partial class God_Cudno : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=судоходство");
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        public God_Cudno()
        {
            InitializeComponent();
            command = new MySqlCommand("SELECT `Годовая эксплуатация судна,%` FROM `судоходство`.`glavnoe`", connection); 
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
