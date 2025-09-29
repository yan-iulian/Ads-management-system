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
    public partial class CheltuieliForm : Form
    {

        private int campanieId;

        public CheltuieliForm(  int campanieId)
        {
            InitializeComponent();
            this.campanieId = campanieId;
            AfiseazaCheltuieli();
        }

        private void AfiseazaCheltuieli()
        {
            BazaDeDateCheltuieli db = new BazaDeDateCheltuieli();
            DataTable cheltuieli = db.GetCheltuieliByCampanieId(campanieId);

            cheltuieliGridView.Columns.Clear();
            cheltuieliGridView.DataSource = null;
            cheltuieliGridView.AutoGenerateColumns = false;

            AddTextBoxColumn("CHELTUIALAID", "ID", "CHELTUIALAID",50);
            AddTextBoxColumn("CATEGORIE", "Categorie", "CATEGORIE");
            AddTextBoxColumn("SUMA", "Sumă", "SUMA",50);
            AddTextBoxColumn("DATACHELTUIALA", "Dată", "DATACHELTUIALA");
            AddTextBoxColumn("DESCRIERE", "Descriere", "DESCRIERE",160);

            

            cheltuieliGridView.DataSource = cheltuieli;
        }

        private void AddTextBoxColumn(string name, string headerText, string dataPropertyName, int width=100)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.HeaderText = headerText;
            column.Width = width;
            column.DataPropertyName = dataPropertyName;
            cheltuieliGridView.Columns.Add(column);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void totalCheltuieliButton_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in cheltuieliGridView.Rows)
            {
                if (row.Cells["SUMA"].Value != null && decimal.TryParse(row.Cells["SUMA"].Value.ToString(), out decimal suma))
                {
                    total += suma;
                }
            }

            MessageBox.Show($"Totalul cheltuielilor este: {total} RON", "Total Cheltuieli", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
