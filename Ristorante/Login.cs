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
    public partial class Login : Form

    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            }

            if (log == 1)
            {
                Cliente Cliente = new Cliente(); //apro form cliente
                Cliente.Show();
            }

            if (log == 2)
            {
                MessageBox.Show("error"); //messaggio di errore
            }
        }
    }
}
