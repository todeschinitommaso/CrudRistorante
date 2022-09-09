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
    public partial class Login : Form

    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @".\menu\";
            if (Directory.Exists(path))
            {
            }
            else
            {
                Directory.CreateDirectory(path);
                path = @".\menu\1\";
                Directory.CreateDirectory(path);
                path = @".\menu\2\";
                Directory.CreateDirectory(path);
                path = @".\menu\3\";
                Directory.CreateDirectory(path);
                path = @".\menu\4\";
                Directory.CreateDirectory(path);
                path = @".\menu\5\";
                Directory.CreateDirectory(path);
            }
        }

        public int login()
        {
            if (userbox.Text == "proprietario" && passbox.Text == "pass") //account proprietario
            {
                return 0;
            }
            if (userbox.Text == "cliente" && passbox.Text == "pass") //account cliente
            {
                return 1;
            }

            else //dati errati
            {
                return 2; 
            }
        }

        private void loginbutton_Click(object sender, EventArgs e) //tasto login
        {
            int log = login();
            if (log == 0 )
            {
                Proprietario Proprietario = new Proprietario(); //apro form proprietario
                Proprietario.Show();
                this.Visible = false;
            }

            if (log == 1)
            {
                Cliente Cliente = new Cliente(); //apro form cliente
                Cliente.Show();
                this.Visible = false;
            }

            if (log == 2)
            {
                MessageBox.Show("error"); //messaggio di errore
            }
        }
    }
}
