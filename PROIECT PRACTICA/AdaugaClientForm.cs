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
    public partial class AdaugaClientForm : Form
    {
        private BazaDeDateClienti bazaDeDate;

        public AdaugaClientForm()
        {
            InitializeComponent();
            bazaDeDate = new BazaDeDateClienti();
            SeteazaClientIdNou();
            tipClientComboBox.Items.AddRange(new[] { "Persoana Fizica", "Firma" });
            tipClientComboBox.SelectedIndex = 0;

            salveazaButton.Enabled = false; // dezactivăm butonul la început
            acceptaCheckBox.CheckedChanged += acceptaCheckBox_CheckedChanged;
        }

        private void SeteazaClientIdNou()
        {
            int idMaxim = bazaDeDate.GetUltimulClientId(); // metoda implementată în BazaDeDateClienti
            idTextBox.Text = (idMaxim + 1).ToString();
            idTextBox.ReadOnly = true;
        }

        private void salveazaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client clientNou = new Client
                {
                    ClientId = int.Parse(idTextBox.Text),
                    Nume = numeTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    Telefon = telefonMaskedTextBox.Text.Trim(),
                    Adresa = adresaTextBox.Text.Trim(),
                    TipClient = tipClientComboBox.SelectedItem.ToString()
                };

                bazaDeDate.AdaugaClient(clientNou);
                MessageBox.Show("Client adăugat cu succes!");
                this.Close(); // închidem formularul
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void acceptaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            salveazaButton.Enabled = acceptaCheckBox.Checked;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
