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
    public partial class SceltaDomanda : Form
    {
        public int turno = 0;
        public static int corretteUtente1 = 0;
        public static int corretteUtente2 = 0;
        public static  string username1;
        public static string username2;


        public SceltaDomanda(string username1_, string username2_)
        {
            InitializeComponent();
            labelUtente.BackColor = System.Drawing.Color.Transparent;

            SceltaDomanda.username1 = username1_;
            SceltaDomanda.username2 = username2_;
           
            labelUtente.Text = "Tocca a te " + username1;
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            string materia = "";
            //MessageBox.Show("" + turno);

            if (sender == button1)
            {
                materia = "Geografia";
                button1.Enabled = false;
            }
            if (sender == button2)
            {
                materia = "Storia";
                button2.Enabled = false;
            }

            if (sender == button3)
            {
                materia = "Cinema";
                button3.Enabled = false;
            }
            if (sender == button4)
            {
                materia = "Musica";
                button4.Enabled = false;
            }
            if (sender == button5)
            {
                materia = "Sport";
                button5.Enabled = false;
            }
            if (sender == button6)
            {
                materia = "Informatica";
                button6.Enabled = false;
            }
            if (sender == button7)
            {
                materia = "Vip";
                button7.Enabled = false;
            }
            if (sender == button8)
            {
                materia = "Scienze";
                button8.Enabled = false;
            }
            if (sender == button9)
            {
                materia = "Cultura Generale";
                button9.Enabled = false;
            }


            if (turno % 2 == 0)
            {
                labelUtente.Text = "Tocca a te " + username1;
                SceltaRisposta f = new SceltaRisposta(materia,turno);
                f.ShowDialog();
            }
                

            if (turno % 2 == 1 && turno == 1)
            {
                labelUtente.Text = "Tocca a te " + username2;
                SceltaRisposta f = new SceltaRisposta(materia,turno);
                f.ShowDialog();
            }


            turno++;

            if (corretteUtente1 == 6)
            {
                MessageBox.Show("IL GIOCATORE " + username1 + " HA VINTO LA PARTITA!!!!!");
                this.Close();
            }
            if (corretteUtente2 == 6)
            {
                MessageBox.Show("IL GIOCATORE " + username2 + " HA VINTO LA PARTITA!!!!!");
                this.Close();
            }

        }
        
        private void labelUtente_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("si funziona");
        }
    }
}
