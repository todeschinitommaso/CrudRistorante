using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristorante
{
    public partial class Proprietario : Form
    {
        public Proprietario()
        {
            InitializeComponent();
        }

        private void Proprietario_Load(object sender, EventArgs e)
        {

        }

        private void addbox_Click(object sender, EventArgs e) //aggiungi piatto
        {
            Aggiungi Aggiungi = new Aggiungi();
            Aggiungi.Show();
        }

        private void editbox_Click(object sender, EventArgs e) //modifica piatto
        {
            Modifica Modifica = new Modifica();
            Modifica.Show();
        }

        private void searchbox_Click(object sender, EventArgs e) //ricerca piatto
        {
            Ricerca Ricerca = new Ricerca();
            Ricerca.Show();
        }

        private void viewbox_Click(object sender, EventArgs e) //visualizza piatto
        {
            Visualizza Visualizza = new Visualizza();
            Visualizza.Show();
        }

        private void deletebox_Click(object sender, EventArgs e) //elimina piatto
        {
            Elimina Elimina = new Elimina();
            Elimina.Show();
        }

        private void recoverbox_Click(object sender, EventArgs e)
        {
            Recupera Recupera = new Recupera();
            Recupera.Show();
        }
    }
}
