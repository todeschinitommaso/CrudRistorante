using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ristorante
{
    public partial class Elimina : Form
    {

        public string piatto = "";

        public string path = "";

        public string cestino = $@".\menu\5\";

        public Elimina()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(namebox.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il nome di un piatto");
            }

            else
            {
                if (path != null)
                {
                    panel2.BringToFront();
                }
            }
        }

        public string CercaPiatto(string piatto) //Controllo se il piatto esiste o meno
        {
            //ANTIPASTO
            string path = $@".\menu\1\{piatto}.txt";

            if (File.Exists(path))
            {
                return path;
            }

            //PRIMO
            path = $@".\menu\2\{piatto}.txt";

            if (File.Exists(path))
            {
                return path;
            }

            //SECONDO
            path = $@".\menu\3\{piatto}.txt";

            if (File.Exists(path))
            {
                return path;
            }

            //DESSERT
            path = $@".\menu\4\{piatto}.txt";

            if (File.Exists(path))
            {
                return path;
            }

            //ERRORE
            MessageBox.Show("Piatto inesistente");

            return null;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            piatto = namebox.Text;
            path = CercaPiatto(piatto);

            cestino = cestino + piatto + ".txt";
            File.Move(path, cestino);

            MessageBox.Show("Piatto spostato nel cestino");
            this.Close();
        }

        private void Elimina_Load(object sender, EventArgs e)
        {

        }
    }
}
