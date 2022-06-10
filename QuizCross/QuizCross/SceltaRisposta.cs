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
    public partial class SceltaRisposta : Form
    {
        private string stringaConnMySql = "Server=localhost;Uid=root;Pwd=''";
        private string stringaConn = "Server=localhost;Database=quizcross;Uid=root;Pwd=''";
        public int cont = 0;
        public int contDomande = 0;
        public int numBotton;
        public string materia2 = "";
        public int domanda1 = -1;
        public int domanda2 = -1;
        public int corretta = 0;
        public int alternanza;
        

        public DataTable GetDomandaGiusta(string materia)
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand("SELECT * FROM domanda WHERE materia = @materia", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Parameters.Add("@materia", MySqlDbType.VarChar);
            com.Parameters["@materia"].Value = materia;
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetRisposteGiuste(int domanda)
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand("SELECT * FROM risposta WHERE domanda = @domanda", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Parameters.Add("@domanda", MySqlDbType.VarChar);
            com.Parameters["@domanda"].Value = domanda;
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public void mostraDomanda(string materia)
        {

            DataTable supporto = GetDomandaGiusta(materia);
          
            int idDomanda = 0;
            int domandaRandom;
            int flag = 0;
            Random rnd = new Random();
            
                do
                {
                    domandaRandom = rnd.Next(0, supporto.Rows.Count);

                } while (domandaRandom == domanda1);

                domanda1 = domandaRandom;


                DataTable domanda = GetDomandaGiusta(materia);
                foreach (DataRow dr in domanda.Rows)
                {
                    if (flag == domanda1)
                    {
                        labelDomanda.Text = dr[1].ToString();
                        idDomanda = Int32.Parse(dr[0].ToString());
                        break;
                    }
                    flag++;
                }
            
            int supp = 0;

            DataTable risposte = GetRisposteGiuste(idDomanda);
          
            foreach (DataRow dr in risposte.Rows)
            {
                if (supp == 0)
                    btnRisposta1.Text = dr[1].ToString();
                else if (supp == 1)
                    btnRisposta2.Text = dr[1].ToString();
                else if (supp == 2)
                    btnRisposta3.Text = dr[1].ToString();
                else if (supp == 3)
                    btnRisposta4.Text = dr[1].ToString();
                else
                    break;


                if (dr[3].ToString() == "1")
                {
                    numBotton = supp;

                }
                supp++;
            }

            contDomande++;
        }

        public SceltaRisposta(string materia, int utente)
		{
			InitializeComponent();

            alternanza = utente;

			materia2 = materia;
			this.mostraDomanda(materia);
		}

		private void btnRisposta_Click(object sender, EventArgs e)
		{
			if (sender == btnRisposta1)
			{
                if (numBotton == 0)
                {
                    btnRisposta1.BackColor = Color.Green;

                    if (alternanza % 2 == 0)
                        SceltaDomanda.corretteUtente1++;
                    
                    if (alternanza % 2 == 1)
                        SceltaDomanda.corretteUtente2++;
                        
                }
                else
                    btnRisposta1.BackColor = Color.Red;
			}
			if (sender == btnRisposta2)
			{

				if (numBotton == 1)
				{
					
					btnRisposta2.BackColor = Color.Green;

                    if (alternanza % 2 == 0)
                        SceltaDomanda.corretteUtente1++;

                    if (alternanza % 2 == 1)
                        SceltaDomanda.corretteUtente2++;
                }
				else
					btnRisposta2.BackColor = Color.Red;
			}
			if (sender == btnRisposta3)
			{

				if (numBotton == 2)
				{
					
					btnRisposta3.BackColor = Color.Green;

                    if (alternanza % 2 == 0)
                        SceltaDomanda.corretteUtente1++;

                    if (alternanza % 2 == 1)
                        SceltaDomanda.corretteUtente2++;
                }
				else
					btnRisposta3.BackColor = Color.Red;
			}
			if (sender == btnRisposta4)
			{
				if (numBotton == 3)
				{
					btnRisposta4.BackColor = Color.Green;

                    if (alternanza % 2 == 0)
                        SceltaDomanda.corretteUtente1++;

                    if (alternanza % 2 == 1)
                        SceltaDomanda.corretteUtente2++;
                }
				else
					btnRisposta4.BackColor = Color.Red;
			}

			switch (numBotton)
			{
				case 0:
					btnRisposta1.BackColor = Color.Green;
					break;
				case 1:
					btnRisposta2.BackColor = Color.Green;
					break;
				case 2:
					btnRisposta3.BackColor = Color.Green;
					break;
				case 3:
					btnRisposta4.BackColor = Color.Green;
					break;

			}

            MessageBox.Show("Domande corrette " + SceltaDomanda.username1 + " : " + SceltaDomanda.corretteUtente1 + "\n" + 
                            "Domande corrette " + SceltaDomanda.username2 + " : " + SceltaDomanda.corretteUtente2);

            cont++;
           
            if (cont < 3)
            {
			
	            btnRisposta1.BackColor = Color.White;
                btnRisposta2.BackColor = Color.White;
                btnRisposta3.BackColor = Color.White;
                btnRisposta4.BackColor = Color.White;
                this.mostraDomanda(materia2);
            }
            else
                this.Close();
        }
    }
}
