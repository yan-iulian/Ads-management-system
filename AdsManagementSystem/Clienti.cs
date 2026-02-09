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
    public partial class ClientiForm : Form
    {
        private DataTable clientiOriginal; 


        public ClientiForm()
        {
            InitializeComponent();
            PopulateDataGridView();

            
        }

        private void AddTextBoxColumn(string propertyName, string headerText, int width = 100)
        {
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName; 
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            clientiGridView.Columns.Add(column);
        }

        private void AddButtonColumn(string headerText, string buttonText, string columnName)
        {
            var column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;
            column.Width = 50;
            clientiGridView.Columns.Add(column);
        }

        private void PopulateDataGridView()
        {
            BazaDeDateClienti dbClienti = new BazaDeDateClienti();
            DataTable clienti = dbClienti.GetAllClienti();  

            clientiGridView.AutoGenerateColumns = false; 
            clientiGridView.DataSource = clienti;  

            
            AddTextBoxColumn("CLIENTID", "ID",30);
            AddTextBoxColumn("NUME", "Nume");
            AddTextBoxColumn("EMAIL", "Email",150);
            AddTextBoxColumn("TELEFON", "Telefon");
            AddTextBoxColumn("ADRESA", "Adresă",190);
            AddTextBoxColumn("TIPCLIENT", "Tip Client");
            AddButtonColumn("Detalii", "➡️", "detaliiColumn");

            foreach (DataGridViewColumn column in clientiGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;  
            }
        }

        private void clientiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientiGridView.Columns[e.ColumnIndex].Name == "detaliiColumn" && e.RowIndex >= 0)
            {
                
                var clientIdString = clientiGridView.Rows[e.RowIndex].Cells["CLIENTID"].Value.ToString();

               
                if (int.TryParse(clientIdString, out int clientId))
                {
                    var numeClient = clientiGridView.Rows[e.RowIndex].Cells["NUME"].Value.ToString();
                   
                    MessageBox.Show($"Se vor afișa detalii pentru clientul cu ID-ul: {clientId}");

                    PaginaPersonalaForm paginaDetaliiClient = new PaginaPersonalaForm(clientId, numeClient);
                    paginaDetaliiClient.Show();
                }
                else
                {
                    MessageBox.Show("ID-ul clientului nu este valid.");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AdaugaClientForm add= new AdaugaClientForm();
            add.ShowDialog();
            PopulateDataGridView();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CautaClient(cautaTextBox.Text);
        }

        private void CautaClient(string cautare)
        {
            if (clientiOriginal == null) return;

            DataView view = clientiOriginal.DefaultView;
            view.RowFilter = $"NUME LIKE '%{cautare.Replace("'", "''")}%'";

            clientiGridView.DataSource = view.ToTable(); 
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            BazaDeDateClienti db = new BazaDeDateClienti();
            clientiOriginal = db.GetAllClienti(); 
            clientiGridView.DataSource = clientiOriginal;
        }
    }
}
