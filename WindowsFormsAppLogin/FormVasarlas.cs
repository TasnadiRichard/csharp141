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
using System.Xml;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppLogin
{
    public partial class FormVasarlas : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public FormVasarlas()
        {
            InitializeComponent();
        }

        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "vasarlas";
            connection = new MySqlConnection(sb.ConnectionString);
            command = connection.CreateCommand();

            termekekBetoltese();
        }

        private void termekekBetoltese()
        {
            listBox_termekek.Items.Clear();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "SELECT `termekid`, `termeknev`, `ar`, `db`  FROM `termek` WHERE 1 ORDER BY termeknev";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        termek beolvasottTermek = new termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        listBox_termekek.Items.Add(beolvasottTermek);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_termekek.SelectedIndex < 0)
            {
                return;
            }
            termek kivalasztottTermek = listBox_termekek.SelectedItem as termek;
            textBox_termekid.Text = kivalasztottTermek.termekid.ToString();
            textBox_termeknev.Text = kivalasztottTermek.termeknev.ToString();
            textBox_ar.Text = kivalasztottTermek.ar.ToString();
            numericUpDown_db.Value = kivalasztottTermek.db;
        }

        private void button_vasarlas_Click(object sender, EventArgs e)
        {
            if (listBox_termekek.SelectedIndex < 0)
            {
                return;
            }
            termek KivalasztottTermek = (termek)listBox_termekek.SelectedItem;

            string KosarElem = $"{KivalasztottTermek.termeknev} - {KivalasztottTermek.db} - {KivalasztottTermek.ar} Ft/db";
            listBox_kosar.Items.Add(KosarElem);
        }

        private void textBox_vegosszeg_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}
