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
    public partial class ProduseForm : Form
    {
        private int campanieId;
       


        public ProduseForm(int idCampanie)
        {
            InitializeComponent();
            campanieId = idCampanie;
            AfiseazaProduse();

        }

        private void AddTextBoxColumn(string name, string headerText,  string dataPropertyName, int width = 100)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.HeaderText = headerText;
            column.Width = width;
            column.DataPropertyName = dataPropertyName;
            produseGridView.Columns.Add(column);
        }


        private void AfiseazaProduse()
        {
            BazaDeDateProduse db = new BazaDeDateProduse();
            DataTable produse = db.GetProduseByCampanieId(campanieId);

            produseGridView.Columns.Clear();
            produseGridView.DataSource = null;
            produseGridView.AutoGenerateColumns = false;

            AddTextBoxColumn("PRODUSID", "ID", "PRODUSID");
            AddTextBoxColumn("NUMEPRODUS", "Nume Produs", "NUMEPRODUS");
            AddTextBoxColumn("TIPPRODUS", "Tip Produs", "TIPPRODUS");
            AddTextBoxColumn("PRETUNITAR", "Preț Unitar", "PRETUNITAR",50);
            AddTextBoxColumn("CANTITATE", "Cantitate", "CANTITATE",65);


            produseGridView.DataSource = produse;


            foreach (DataGridViewColumn column in produseGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double sumaTotala = 0;

            
            foreach (DataGridViewRow row in produseGridView.Rows)
            {
                if (row.IsNewRow) continue;

                
                double pretUnitar = Convert.ToDouble(row.Cells["PRETUNITAR"].Value);
                int cantitate = Convert.ToInt32(row.Cells["CANTITATE"].Value);

                
                sumaTotala += pretUnitar * cantitate;
            }

            MessageBox.Show($"Suma totală pentru produse este: {sumaTotala} lei", "Total Produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
