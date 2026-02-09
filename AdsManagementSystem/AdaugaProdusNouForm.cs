using PROIECT_PRACTICA.BazaDeDate;
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
    public partial class AdaugaProdusNouForm : Form
    {
        public AdaugaProdusNouForm()
        {
            InitializeComponent();
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void AdaugaProdusNouForm_Load(object sender, EventArgs e)
        {
            BazaDeDateProduse db = new BazaDeDateProduse();
            int produsIdNou = db.GetUltimulProdusId() + 1;

            idNumeric.Text = produsIdNou.ToString();
          
            
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            string numeProdus = numeTextBox.Text;
            string tipProdus = tipProdusTextBox.Text;
            decimal pretUnitar = Convert.ToDecimal(pretUnitarTextBox.Text);

            // Verificăm dacă sunt complete toate câmpurile
            if (string.IsNullOrEmpty(numeProdus) || string.IsNullOrEmpty(tipProdus) || pretUnitar <= 0)
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile corect.");
                return;
            }

            BazaDeDateProduse db = new BazaDeDateProduse();
            bool produsAdaugat = db.AdaugaProdus(numeProdus, tipProdus, pretUnitar);

            if (produsAdaugat)
            {
                MessageBox.Show("Produsul a fost adăugat cu succes!");
                this.Close(); // Închide formularul după adăugare
            }
            else
            {
                MessageBox.Show("A apărut o eroare la adăugarea produsului.");
            }
        }

    }
 }
