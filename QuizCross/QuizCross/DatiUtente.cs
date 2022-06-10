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

namespace QuizCross
{
    public partial class DatiUtente : Form
    {
        private string stringaConnMySql = "Server=localhost;Uid=root;Pwd=''";
        private string stringaConn = "Server=localhost;Database=quizcross;Uid=root;Pwd=''";


        public void aggiungiUtente(string username1)
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            conn.Open();
            com.CommandText =
                "INSERT INTO utente (username,avatar,giocate,vittorie) VALUES(@username,'uomo',1,0);";
                
            com.Parameters.Add("@username", MySqlDbType.VarChar);
            com.Parameters["@username"].Value = username1;

            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();
        }


        public DatiUtente()
        {
            InitializeComponent();
            CreateDb c = new CreateDb();
            //c.DropDb();

            //CreateDb c = new CreateDb();
            c.CreaDb();
            c.CreaTabelle();
            c.PopolaTabelle();
            
        }
       

        private void btnGioca_Click(object sender, EventArgs e)
        {
            string username1 = textBoxUsername1.Text;
            string username2 = textBoxUsername2.Text;

            aggiungiUtente(username1);
            aggiungiUtente(username2);


            SceltaDomanda f = new SceltaDomanda(username1, username2);
            f.ShowDialog();
        }
        
        private void DatiUtente_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateDb c = new CreateDb();
            c.DropDb();
        }
    }
}
