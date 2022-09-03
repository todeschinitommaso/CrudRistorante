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
    public partial class Recupera : Form
    {

        public string path = $@".\menu\5\";
        public string cestinopath = $@".\menu\5\";

        public string file;

        public bool Antipasto;
        public bool Primo;
        public bool Secondo;
        public bool Dessert;

        public Recupera()
        {
            InitializeComponent();
        }

        private void Recupera_Load(object sender, EventArgs e)
        {
            List<string> antipastidirs = new List<string>(Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories));
            BinLoad(antipastidirs);
        }

        public void BinLoad(List<string> dirs) //LISTA ANTIPASTI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolto .txt dal nome
                cestino.Items.Add(name);
            }
        }

        public int CheckPortata() //controlli riguardo la selezione della portata
        {
            if (Antipasto == false && Primo == false && Secondo == false && Dessert == false)
            {
                MessageBox.Show("Seleziona una portata");
                return 0;
            }

            if (Antipasto == true && Primo == false && Secondo == false && Dessert == false)
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

        private void cestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            file = cestino.SelectedItem.ToString(); 
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(file == String.Empty)
            {
                MessageBox.Show("Seleziona un piatto");
            }
            else
            {
                int check = CheckPortata();

                path = FoldSwitch(path, check);

                path = path + file + ".txt";
                cestinopath = cestinopath + file + ".txt";

                File.Move(cestinopath, path);
                MessageBox.Show("Piatto spostato con successo");
                this.Close();
            }
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
    }
}
