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
            numericUpDown_db.Maximum = kivalasztottTermek.db;
            kivalasztottTermek.termekid = 0;
        }

        private void button_vasarlas_Click(object sender, EventArgs e)
        {
            //-- erősítse meg a vásárlási szándékot
            string szoveg = $"Valóban meg akar vásárolni {numericUpDown_db.Value} db {textBox_termeknev.Text} terméket {numericUpDown_db.Value = numericUpDown_db.Value} Ft értékben?";
            if (MessageBox.Show(szoveg,"megerősítés", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No) 
            {

            }
            MySqlTransaction tr = null;

            try
            {
                tr = Program.connection.BeginTransaction();
                Program.command.Transaction = tr; //-- Start transaction 
                                                  // -- vásárlás adatainak rögzítése
                Program.command.CommandText = "INSERT INTO `vasarlas` (`vasarloid`, `termekid`, `datum`, `vasaroltdb`) VALUES(@vasarloid, '@termekid', '@vasaroltdb')";
                Program.command.Parameters.Clear();
                Program.command.Parameters.AddWithValue("@vasarloid", Program.UserID);
                Program.command.Parameters.AddWithValue("@termekid", textBox_termekid.Text);
                Program.command.Parameters.AddWithValue("@vasaroltdb", numericUpDown_db.Value);
                Program.command.ExecuteNonQuery();
                //-- a raktárkészlet aktualizálása az eladott mennyiséggel
                Program.command.CommandText = $"UPDATE `termek` SET `db`= db-{numericUpDown_db.Value} WHERE `termekid` = {textBox_termekid.Text}";
                Program.command.ExecuteNonQuery();
                tr.Commit();
                textBox_termekid.Text = "";
                numericUpDown_raktarkeszlet.Value = numericUpDown_raktarkeszlet.Value;
                numericUpDown_db.Value = numericUpDown_db.Value;
                textBox_termeknev.Text = textBox_termeknev.Text;
                MessageBox.Show("Sikeres vásárlás!");
            }
            catch (MySqlException ex)
            {
                tr.Rollback();
                MessageBox.Show("Sikertelen vásárlás!");
            }
            updateTermekekLista();
        }
                

        private void updateTermekekLista()
        {
            throw new NotImplementedException();
        }

        private void textBox_vegosszeg_TextChanged(object sender, EventArgs e)
        {
      
        }
        
        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek formTermekUj = new Form_Termek("új");
            formTermekUj.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek formTermekModositas = new Form_Termek("módosítás");
            formTermekModositas.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek formTermekTorles = new Form_Termek("módosítás");
            formTermekTorles.ShowDialog();
        }
    }
}
