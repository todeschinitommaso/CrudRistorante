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
    public partial class Ricerca : Form
    {
        public string piatto = "";

        public string path = "";

        public Ricerca()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            Nome(path);
        }

        public void Nome(string path) //Controlli relativi alla namebox
        {
            if (namebox.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il nome del piatto");
            }

            else
            {
                piatto = namebox.Text;
                path = CercaPiatto(piatto);

                if (path != null) //Lettura file
                {
                    Reader(path);
                }
            }
        }

        public void Reader(string path) //lettura file
        {
            StreamReader sr = new StreamReader(path);
            pricelabel.Text = sr.ReadLine();
            firstlabel.Text = sr.ReadLine();
            secondlabel.Text = sr.ReadLine();
            thirdlabel.Text = sr.ReadLine();
            fourthlabel.Text = sr.ReadLine();
            sr.Close();
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

        private void Ricerca_Load(object sender, EventArgs e)
        {

        }
    }
}
