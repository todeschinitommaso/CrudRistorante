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
    public partial class Aggiungi : Form
    {

        public string path = @".\menu\";

        public bool Antipasto;
        public bool Primo;
        public bool Secondo;
        public bool Dessert;

        public Aggiungi()
        {
            InitializeComponent();
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            bool check2 = CheckNomePrezzo();
            if (check2 == false)
            {
                MessageBox.Show("Compila tutti i campi obbligatori");
            }

            else
            {
                int check = CheckPortata();

                path = FoldSwitch(path, check);

                Write(path);

                MessageBox.Show("Aggiunto con successo");
                this.Close();
            }
        }

        public bool CheckNomePrezzo()
        {
            if(textBox1.Text == string.Empty)
            {
                return false;
            }

            if(textBox2.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        public void Exist(string path)
        {
            if(File.Exists(path))
            {
                MessageBox.Show("il piatto esiste giá");
            }
        }

        public void Write(string path)
        {
            path = path + textBox1.Text + ".txt";

            Exist(path);

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox5.Text);
            sw.WriteLine(textBox6.Text);
            sw.Close();
        }

        public string FoldSwitch(string path, int check) //in base alla portata seleziono una cartella differente
        {
            if (check == 1)
            {
                path = @"menu\1\";
            }

            if (check == 2)
            {
                path = @"menu\2\"; ;
            }

            if (check == 3)
            {
                path = @"menu\3\";
            }

            if (check == 4)
            {
                path = @"menu\4\";
            }

            return path;
        }

        public int CheckPortata() //controlli riguardo la selezione della portata
        {
            if (Antipasto == false && Primo == false && Secondo == false && Dessert == false)
            {
                MessageBox.Show("Seleziona una portata");
                return 0;
            }

            if(Antipasto == true && Primo == false && Secondo == false && Dessert ==  false)
            {
                return 1;
            }

            if (Antipasto == false && Primo == true && Secondo == false && Dessert == false)
            {
                return 2;
            }

            if (Antipasto == false && Primo == false && Secondo == true && Dessert == false)
            {
                return 3;
            }

            if (Antipasto == false && Primo == false && Secondo == false && Dessert == true)
            {
                return 4;
            }

            else
            {
                MessageBox.Show("seleziona una sola portata");
                return 0;
            }
        }

        //ANTIPASTO
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Antipasto = false;
            }

            if (checkBox1.Checked == true)
            {
                Antipasto = true;
            }
        }

        //PRIMO
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                Primo = false;
            }

            if (checkBox2.Checked == true)
            {
                Primo = true;
            }
        }

        //SECONDO
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                Secondo = false;
            }

            if (checkBox3.Checked == true)
            {
                Secondo = true;
            }
        }

        //DESSERT
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                Dessert = false;
            }

            if (checkBox4.Checked == true)
            {
                Dessert = true;
            }
        }

        private void Aggiungi_Load(object sender, EventArgs e)
        {

        }
    }
}
