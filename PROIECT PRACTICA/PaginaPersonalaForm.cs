using PROIECT_PRACTICA.BazaDeDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PRACTICA
{
    public partial class PaginaPersonalaForm : Form
    {
        private int clientId;
        private string numeClient;


        public PaginaPersonalaForm(int idClient, string numeClient)
        {
            InitializeComponent();

            this.clientId = idClient;
            this.numeClient = numeClient;

            AfiseazaDateClient();
            AfiseazaDetaliiCampanie(idClient);
        }


        private void AfiseazaDateClient()
        {
            BazaDeDateClienti db = new BazaDeDateClienti();
            DataRow client = db.GetClientById(clientId);

            if (client != null)
            {
                numeDCLabel.Text = client["NUME"].ToString();
                numeLabel.Text= client["NUME"].ToString().ToUpper();
                emailDCLabel.Text = client["EMAIL"].ToString();
                telefonDCLabel.Text = client["TELEFON"].ToString();
                adresaDCLabel.Text = client["ADRESA"].ToString();
                tipClientDCLabel.Text = client["TIPCLIENT"].ToString();
            }
        }

        private void AfiseazaDetaliiCampanie(int idClient)
        {
            
            BazaDeDateCampanii dbCampanii = new BazaDeDateCampanii();

            bool areCampanieActiva = dbCampanii.ExistaCampaniePentruClient(idClient);

            if (areCampanieActiva)
            {
                statusCLabel.Text = "Activ";
                statusInactivLabel.Visible = false; // Ascundem "Status Inactiv"

                DataRow campanie = dbCampanii.GetCampanieByClientId(idClient);

                numeCLabel.Text = campanie["DENUMIRECAMPANIE"].ToString();
                dataStartCLabel.Text = campanie["DATASTART"].ToString();
                dataSfarsitCLabel.Text = campanie["DATASFARSIT"].ToString();
                bugetCLabel.Text = campanie["BUGETTOTAL"].ToString();

                campanieGroupBox.Visible = true;

                int numarProduse = dbCampanii.GetNrProduseInCampanie(idClient);
                numarProduseCLabel.Text =  numarProduse.ToString();
            }
            else
            {
                campanieGroupBox.Visible = false;
                statusInactivLabel.Visible = true;
                statusInactivLabel.Text = "STATUS CAMPANIE  : INACTIV";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stergeButton_Click(object sender, EventArgs e)
        {
            var confirmare = MessageBox.Show($"Sigur dorești să ștergi clientul '{numeClient}'?", "Confirmare ștergere",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmare == DialogResult.Yes)
            {
                BazaDeDateClienti db = new BazaDeDateClienti();
                bool sters = db.StergeClient(clientId);

                if (sters)
                {
                    MessageBox.Show("Clientul a fost șters cu succes.");
                    this.Close(); // Închide formularul
                }
                else
                {
                    MessageBox.Show("A apărut o eroare la ștergerea clientului.");
                }
            }
            
        }

        private void veziProduseButton_Click(object sender, EventArgs e)
        {
            BazaDeDateCampanii dbCampanii = new BazaDeDateCampanii();
            int? campanieId = dbCampanii.GetCampanieIdByClientId(clientId);

            if (campanieId != null)
            {
                ProduseForm produseForm = new ProduseForm(campanieId.Value);
                produseForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Clientul nu are campanie activă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cheltuieliButton_Click(object sender, EventArgs e)
        {
            BazaDeDateCampanii db = new BazaDeDateCampanii();
            int? campanieId = db.GetCampanieIdByClientId(clientId);

            if (campanieId != null)
            {
                CheltuieliForm fereastraCheltuieli = new CheltuieliForm((int)campanieId);
                fereastraCheltuieli.Show();
            }
            else
            {
                MessageBox.Show("Clientul nu are campanie asociată.");
            }
        }

        private void profitButton_Click(object sender, EventArgs e)
        {
            BazaDeDateCheltuieli dbCheltuieli = new BazaDeDateCheltuieli();
            decimal totalCheltuieli = dbCheltuieli.GetTotalCheltuieliByCampanieId(clientId); // sau campanieId dacă îl ai

            decimal buget = 0;
            decimal.TryParse(bugetCLabel.Text, out buget);

            decimal profit = buget - totalCheltuieli;

            MessageBox.Show($"Profitul campaniei este: {profit} RON", "Profit Campanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void genereazaFacturaButton_Click(object sender, EventArgs e)
        {
            BazaDeDateProduse db = new BazaDeDateProduse();
            BazaDeDateCampanii dbCampanii = new BazaDeDateCampanii();

            int? campanieId = dbCampanii.GetCampanieIdByClientId(clientId);
            if (campanieId == null)
            {
                MessageBox.Show("Clientul nu are campanie activă.");
                return;
            }

            DataTable produse = db.GetProduseByCampanieId(campanieId.Value);
            string denumireCampanie = dbCampanii.GetCampanieByClientId(clientId)["DENUMIRECAMPANIE"].ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FACTURA");
            sb.AppendLine($"Client: {numeClient}");
            sb.AppendLine($"Campanie: {denumireCampanie}");
            sb.AppendLine($"Data: {DateTime.Now.ToString("dd/MM/yyyy")}");
            sb.AppendLine();
            sb.AppendLine("Produse:");
            sb.AppendLine("---------------------------------------------------");

            decimal total = 0;

            foreach (DataRow row in produse.Rows)
            {
                string nume = row["NUMEPRODUS"].ToString();
                decimal pret = Convert.ToDecimal(row["PRETUNITAR"]);
                int cantitate = Convert.ToInt32(row["CANTITATE"]);
                decimal subtotal = pret * cantitate;

                sb.AppendLine($"{nume} - {cantitate} x {pret} RON = {subtotal} RON");
                total += subtotal;
            }

            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine($"Total: {total} RON");
            decimal tva = total * 0.19m;
            sb.AppendLine($"TVA (19%): {tva} RON");
            sb.AppendLine($"Total cu TVA: {total + tva} RON");

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = $"Factura_{numeClient.Replace(" ", "_")}.txt";
            string fullPath = Path.Combine(desktopPath, fileName);

            File.WriteAllText(fullPath, sb.ToString());

            MessageBox.Show($"Factura a fost generată cu succes pe Desktop:\n{fullPath}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
