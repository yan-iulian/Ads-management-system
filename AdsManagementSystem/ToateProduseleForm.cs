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
    public partial class ToateProduseleForm : Form
    {
        private DataTable produseOriginal;

        public ToateProduseleForm()
        {
            InitializeComponent();
            AfiseazaToateProdusele();
        }


        private void AddTextBoxColumn(string header, string propertyName, int width, string name)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = propertyName;
            column.Width = width;
            column.Name = name;
            column.ReadOnly = true;

            toateProduseleGridView.Columns.Add(column);
        }

        private void AfiseazaToateProdusele()
        {
            BazaDeDateProduse db = new BazaDeDateProduse();
            DataTable produse = db.GetToateProdusele();

            toateProduseleGridView.Columns.Clear();
            toateProduseleGridView.DataSource = null;
            toateProduseleGridView.AutoGenerateColumns = false;

            // Adăugăm manual coloanele
            AddTextBoxColumn("ID Produs", "PRODUSID", 80, "produsIdColumn");
            AddTextBoxColumn("Nume Produs", "NUMEPRODUS", 150, "numeProdusColumn");
            AddTextBoxColumn("Tip Produs", "TIPPRODUS", 120, "tipProdusColumn");
            AddTextBoxColumn("Preț Unitar", "PRETUNITAR", 70, "pretUnitarColumn");
            AddButtonColumn("Sterge", "stergeProdusColumn", "🗑️");

            toateProduseleGridView.DataSource = produse;

            foreach (DataGridViewColumn column in toateProduseleGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adaugaProdusButton_Click(object sender, EventArgs e)
        {
            AdaugaProdusNouForm form = new AdaugaProdusNouForm();
            form.Show();
        }

        private void cautaTextBox_TextChanged(object sender, EventArgs e)
        {
            FiltreazaProduse(cautaTextBox.Text);
        }

        private void ToateProduseleForm_Load(object sender, EventArgs e)
        {
            BazaDeDateProduse db = new BazaDeDateProduse();
            produseOriginal = db.GetToateProdusele();
            toateProduseleGridView.DataSource = produseOriginal;
        }

        private void FiltreazaProduse(string cautare)
        {
            if (produseOriginal == null) return;

            DataView view = produseOriginal.DefaultView;
            view.RowFilter = $"NUMEPRODUS LIKE '%{cautare.Replace("'", "''")}%'"; // caută după nume produs

            toateProduseleGridView.DataSource = view.ToTable();
        }


        private void AddButtonColumn(string header, string name, string text)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = header;
            buttonColumn.Name = name;
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Width = 70;
            toateProduseleGridView.Columns.Add(buttonColumn);
        }

        private void toateProduseleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificăm dacă a fost apăsat butonul de ștergere
            if (e.RowIndex >= 0 && toateProduseleGridView.Columns[e.ColumnIndex].Name == "stergeProdusColumn")
            {
                int produsId = Convert.ToInt32(toateProduseleGridView.Rows[e.RowIndex].Cells["produsIdColumn"].Value);
                string numeProdus = toateProduseleGridView.Rows[e.RowIndex].Cells["numeProdusColumn"].Value.ToString();

                var confirmare = MessageBox.Show($"Sigur dorești să ștergi produsul '{numeProdus}'?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmare == DialogResult.Yes)
                {
                    BazaDeDateProduse db = new BazaDeDateProduse();
                    bool sters = db.StergeProdus(produsId);

                    if (sters)
                    {
                        MessageBox.Show("Produsul a fost șters cu succes.");
                        AfiseazaToateProdusele(); // Reîncarcă datele
                    }
                    else
                    {
                        MessageBox.Show("A apărut o eroare la ștergerea produsului.");
                    }
                }
            }
        }
    }
}
