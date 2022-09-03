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
    public partial class Modifica : Form
    {
        public string piatto = "";

        public string path = "";

        public Modifica()
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

                if(path != null) //Lettura file
                {
                    Reader(path);
                }
            }
        }

        public void Writer(string path) //scrittura file
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(pricebox.Text);
            sw.WriteLine(firstbox.Text);
            sw.WriteLine(secondbox.Text);
            sw.WriteLine(thirdbox.Text);
            sw.WriteLine(fourthbox.Text);
            sw.Close();
        }

        public void Reader(string path) //lettura file
        {
            StreamReader sr = new StreamReader(path);
            pricebox.Text = sr.ReadLine();
            firstbox.Text = sr.ReadLine();
            secondbox.Text = sr.ReadLine();
            thirdbox.Text = sr.ReadLine();
            fourthbox.Text = sr.ReadLine();
            sr.Close();
        }

        public string CercaPiatto(string piatto) //Controllo se il piatto esiste o meno
        {
            //ANTIPASTO
            string path = $@".\menu\1\{piatto}.txt";

            if(File.Exists(path))
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

        private void savebutton_Click(object sender, EventArgs e)
        {
            path = CercaPiatto(piatto);

            Writer(path); //riscrivo i dati modificati

            MessageBox.Show("Modificato con successo");
            this.Close();
        }
    }
}
