﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppLogin
{
    internal static class Program
    {

        public static FormLogin formLogin=null;
        public static FormVasarlas formVasarlas=null;
        public static Form_Termek Form_Termek = null;
        public static MySqlConnection connection = null;
        public static MySqlCommand command = null;
        public static int UserID;
        static void Main()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "vasarlas";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                connection.Open();
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin = new FormLogin();
            formVasarlas = new FormVasarlas();
            Form_Termek = new Form_Termek();
            Application.Run(formLogin);
            
        }
    }
}
