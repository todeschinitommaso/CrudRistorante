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
    public partial class Cliente : Form
    {
        public string antipastipath = $@".\menu\1\";
        public string primipath = $@".\menu\2\";
        public string secondipath = $@".\menu\3\";
        public string dessertpath = $@".\menu\4\";

        public string path;
        public int price = 0;

        public string nomeordine;

        public string[] arr = new string[3];

        public string ingr;

        public int a = 1;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            List<string> antipastidirs = new List<string>(Directory.EnumerateFiles(antipastipath, "*.txt", SearchOption.AllDirectories));
            AntipastiLoad(antipastidirs);

            List<string> primidirs = new List<string>(Directory.EnumerateFiles(primipath, "*.txt", SearchOption.AllDirectories));
            PrimiLoad(primidirs);

            List<string> secondidirs = new List<string>(Directory.EnumerateFiles(secondipath, "*.txt", SearchOption.AllDirectories));
            SecondiLoad(secondidirs);

            List<string> dessertdirs = new List<string>(Directory.EnumerateFiles(dessertpath, "*.txt", SearchOption.AllDirectories));
            DessertLoad(dessertdirs);

        }

        public void AntipastiLoad(List<string> dirs) //LISTA ANTIPASTI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolto .txt dal nome

                arr[0] = name;

                antipastipath = antipastipath + name + ".txt";
                Reader(antipastipath, arr, ingr);

                ListViewItem itm;

                itm = new ListViewItem(arr);
                menu.Items.Add(itm);

                antipastipath = $@".\menu\1\";
            }
        }

        public void PrimiLoad(List<string> dirs) //LISTA ANTIPASTI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolto .txt dal nome

                arr[0] = name;

                primipath = primipath + name + ".txt";
                Reader(primipath, arr, ingr);

                ListViewItem itm;

                itm = new ListViewItem(arr);
                menu.Items.Add(itm);

                primipath = $@".\menu\2\";
            }
        }

        public void SecondiLoad(List<string> dirs) //LISTA ANTIPASTI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolto .txt dal nome

                arr[0] = name;

                secondipath = secondipath + name + ".txt";
                Reader(secondipath, arr, ingr);

                ListViewItem itm;

                itm = new ListViewItem(arr);
                menu.Items.Add(itm);

                secondipath = $@".\menu\3\";
            }
        }

        public void DessertLoad(List<string> dirs) //LISTA ANTIPASTI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolto .txt dal nome

                arr[0] = name;

                dessertpath = dessertpath + name + ".txt";
                Reader(dessertpath, arr, ingr);

                ListViewItem itm;

                itm = new ListViewItem(arr);
                menu.Items.Add(itm);

                dessertpath = $@".\menu\4\";
            }
        }

        public void Reader(string path, string[] arr, string ingr)
        {
            StreamReader sr = new StreamReader(path);
            arr[2] = sr.ReadLine();

            ingr = sr.ReadLine() + "; " + sr.ReadLine() + "; " + sr.ReadLine() + "; " + sr.ReadLine();
            arr[1] = ingr;
        }

        private void menu_DoubleClick(object sender, EventArgs e)
        {
            string name = menu.SelectedItems[0].Text; //salva il nome del piatto cliccato
            ordini.Items.Add(name);

            path = CercaPiatto(name);

            price = price + PriceReader(path);

            totprice.Text = price.ToString();
        }

        public int PriceReader(string path)
        {
            StreamReader pricereader = new StreamReader(path);
            int a = int.Parse(pricereader.ReadLine());
            return a;
        }

        //RICERCA
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

            if(File.Exists(path))
            {
                return path;
            }

            //ERRORE
            MessageBox.Show("Piatto inesistente");

            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nameordine = ordini.SelectedItem.ToString(); //SISTEMARE QUI LA STRINGA RISULTA VUOTA

            path = CercaPiatto(nameordine);

            int temp = int.Parse(totprice.Text);
            temp = temp - PriceReader(path);

            totprice.Text = temp.ToString();

            ordini.Items.RemoveAt(ordini.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (totprice.Text == "0")
            {
                MessageBox.Show("Ordina almeno un piatto");
            }

            else
            {
                MessageBox.Show("Ordine registrato correttamente");
                this.Close();
            }
        }
    }
}
