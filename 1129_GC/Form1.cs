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

namespace _1129_GC
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            conn = new MySqlConnection(
                "Server=winsql.vereb.dc;" +
                "Database=diak71;" +
                "Uid=diak71;" +
                "Pwd=FHWxBh;");
            InitializeComponent();
            FillDGV();

        }

        private void FillDGV()
        {
            dtg_datagrid.Rows.Clear();
            conn.Open();

            var cmd = new MySqlCommand("SELECT * FROM pokemonok;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dtg_datagrid.Rows.Add(r[0], r[1], r[2]);
            }
            conn.Close();
        }

        private void Bt_newpokemon_Click(object sender, EventArgs e)
        {
            conn.Open();

            var a = new MySqlDataAdapter()
            {
                InsertCommand = new MySqlCommand("INSERT INTO pokemonok VALUES " +
                $"('{tb_nev.Text}', '{tb_tipus.Text}');", conn),
            };
            a.InsertCommand.ExecuteNonQuery();

            dtg_datagrid.Refresh();
            MessageBox.Show("Tábla frissítve");
            conn.Close();
        }
        private void Bt_deleteSelected_Click(object sender, EventArgs e)
        {
            conn.Open();
            var a = new MySqlDataAdapter()
            {
                DeleteCommand = new MySqlCommand("DELET FROM pokemonok WHERE " +
                $"id = {dtg_datagrid.SelectedRows[0].Cells[0].Value}", conn),
            };
            a.DeleteCommand.ExecuteNonQuery();

            dtg_datagrid.Refresh();
            MessageBox.Show("Tábla frissítve");
            conn.Close();
        }
    }
}
