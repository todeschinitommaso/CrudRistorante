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
    public partial class Visualizza : Form
    {
        //PERCORSI FILE
        public string antipastipath = $@".\menu\1\";
        public string primipath = $@".\menu\2\";
        public string secondipath = $@".\menu\3\";
        public string dessertpath = $@".\menu\4\";

        public string price;
        public string first;
        public string second;
        public string third;
        public string fourth;

        public Visualizza()
        {
            InitializeComponent();
        }

        //CARICAMENTO LISTE
        private void Visualizza_Load(object sender, EventArgs e)
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


        //RIEMPIMENTO LISTE 
        public void AntipastiLoad(List<string> dirs) //LISTA ANTIPASTI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolto .txt dal nome
                antipasti.Items.Add(name);
            }
        }

        public void PrimiLoad(List<string> dirs) //LISTA PRIMI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = name.Count();
                name = name.Remove(count - 4);
                primi.Items.Add(name);
            }
        }

        public void SecondiLoad(List<string> dirs) //LISTA SECONDI
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = name.Count();
                name = name.Remove(count - 4);
                secondi.Items.Add(name);
            }
        }

        public void DessertLoad(List<string> dirs) //LISTA DESSERT
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = name.Count();
                name = name.Remove(count - 4);
                dessert.Items.Add(name);
            }
        }

        //VISUALIZZAZIONE DEI DATI DI OGNI PIATTO SU CUI VADO A CLICCARE

        //ANTIPASTI
        private void antipasti_SelectedIndexChanged(object sender, EventArgs e) //CLICK SU UN PIATTO NELLA LISTA
        {
            string name = antipasti.SelectedItem.ToString(); //salvo il nome del piatto cliccato

            antipastipath = antipastipath + name + ".txt";

            ReaderWriter(antipastipath, name, price, first, second, third, fourth);

            antipastipath = $@".\menu\1\";
        }

        //PRIMI
        private void primi_SelectedIndexChanged(object sender, EventArgs e)  
        {
            string name = primi.SelectedItem.ToString(); //salvo il nome del piatto cliccato

            primipath = primipath + name + ".txt";

            ReaderWriter(primipath, name, price, first, second, third, fourth);

            primipath = $@".\menu\2\";
        }

        //SECONDI
        private void secondi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = secondi.SelectedItem.ToString(); //salvo il nome del piatto cliccato

            secondipath = secondipath + name + ".txt";

            ReaderWriter(secondipath, name, price, first, second, third, fourth);

            secondipath = $@".\menu\3\";
        }

        //DESSERT
        private void dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = dessert.SelectedItem.ToString(); //salvo il nome del piatto cliccato

            dessertpath = dessertpath + name + ".txt";

            ReaderWriter(dessertpath, name, price, first, second, third, fourth);

            dessertpath = $@".\menu\4\";
        }

        //LETTURA E SCRITTURA DATI IN MESSAGEBOX
        public void ReaderWriter(string path, string name, string price, string first, string second, string third, string fourth) 
        {
            StreamReader sr = new StreamReader(path);
            price = sr.ReadLine();
            first = sr.ReadLine();
            second = sr.ReadLine();
            third = sr.ReadLine();
            fourth = sr.ReadLine();
            sr.Close();

            Writer(name, price, first, second, third, fourth);
        }

        public void Writer(string name,  string price, string first, string second, string third, string fourth)
        {
            MessageBox.Show($"Nome : {name} \n" +
                $"Prezzo: {price} \n" +
                $"1 Ingrediente : {first} \n" +
                $"2 Ingrediente : {second} \n" +
                $"3 Ingrediente : {third} \n" +
                $"4 Ingrediente : {fourth}");
        }
    }
}
