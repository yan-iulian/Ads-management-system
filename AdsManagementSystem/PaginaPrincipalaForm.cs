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
 
    public partial class PaginaPrincipalaForm : Form
    {
        private BazaDeDateUtilizatori bazaDeDate;

        public PaginaPrincipalaForm()
        {
            InitializeComponent();
            bazaDeDate=new BazaDeDateUtilizatori();

        }

        private void PaginaPrincipalaForm_Load(object sender, EventArgs e)
        {
            string numeComplet = bazaDeDate.GetNumeComplet(Sesiune.UsernameCurent);
            titluLabel.Text = $"Bine ai revenit,               {numeComplet.ToUpper()}!";

            string rol=bazaDeDate.GetRol(Sesiune.UsernameCurent);
            functieLabel.Text = $"Functie :     {rol}";

            usernameLabel.Text= $"Username :    {Sesiune.UsernameCurent}";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void clientiButton_Click(object sender, EventArgs e)
        {
            ClientiForm clientiForm = new ClientiForm();
            clientiForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produseButton_Click(object sender, EventArgs e)
        {
            ToateProduseleForm produseForm = new ToateProduseleForm();
            produseForm.Show();
        }
    }
}
