using PROIECT_PRACTICA.BazaDeDate;
using PROIECT_PRACTICA.Entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PRACTICA
{
    public partial class LoginForm : Form
    {

        private BazaDeDateUtilizatori bazaDeDate;

        public LoginForm()
        {
            InitializeComponent();
            bazaDeDate = new BazaDeDateUtilizatori();

            this.KeyDown += new KeyEventHandler(LoginForm_KeyDown);

            
        }

        private void anulareButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void conectareButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Introduceți username și parolă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool esteValida = bazaDeDate.ValidateUser(username, password);

            if (esteValida)
            {
                Sesiune.UsernameCurent = username;

                if (rememberCheckBox.Checked)
                {
                    Sesiune.UsernameMemorat = username;
                }
                else
                {
                    Sesiune.UsernameMemorat = null;
                }

                MessageBox.Show("Autentificare reușită!");

                PaginaPrincipalaForm pp = new PaginaPrincipalaForm();
                pp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username sau parolă incorecte.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Sesiune.UsernameMemorat))
            {
                usernameTextBox.Text = Sesiune.UsernameMemorat;
                rememberCheckBox.Checked = true;
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conectareButton.PerformClick();
            }
        }
    }
}
