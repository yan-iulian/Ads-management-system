using Oracle.ManagedDataAccess.Client;
using PROIECT_PRACTICA.Entitati;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PROIECT_PRACTICA.BazaDeDate
{
    public class BazaDeDateClienti
    {

        private string connectionString;

        public BazaDeDateClienti()
        {
            // Initializare connection string cu datele de conectare la Oracle
            connectionString = "User Id=CATANAN_61;Password=STUD;Data Source=//193.226.34.57:1521/orclpdb.docker.internal;";
        }

       


        public DataTable GetAllClienti()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                DataTable clienti = new DataTable();
                try
                {
                    connection.Open();
                    string query = "SELECT CLIENTID, NUME, EMAIL, TELEFON, ADRESA, TIPCLIENT FROM p_clienti";
                    OracleCommand command = new OracleCommand(query, connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(clienti);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la obținerea clienților: " + ex.Message);
                }
                return clienti;
            }
        }


        public int GetUltimulClientId()
        {
            int idMax = 0;
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT MAX(CLIENTID) FROM P_CLIENTI", conn);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    idMax = Convert.ToInt32(result);
            }
            return idMax;
        }

        public void AdaugaClient(Client client)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("INSERT INTO P_CLIENTI (CLIENTID, NUME, EMAIL, TELEFON, ADRESA, TIPCLIENT) VALUES (:id, :nume, :email, :telefon, :adresa, :tip)", conn);

                cmd.Parameters.Add(":id", client.ClientId);
                cmd.Parameters.Add(":nume", client.Nume);
                cmd.Parameters.Add(":email", client.Email);
                cmd.Parameters.Add(":telefon", client.Telefon);
                cmd.Parameters.Add(":adresa", client.Adresa);
                cmd.Parameters.Add(":tip", client.TipClient);

                cmd.ExecuteNonQuery();
            }
        }

        public DataRow GetClientById(int idClient)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                // Interogăm tabela p_clienti pentru a obține datele clientului pe baza ID-ului
                string query = "SELECT * FROM p_clienti WHERE CLIENTID = :idClient";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("idClient", idClient));

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        DataTable clientDataTable = new DataTable();
                        dataAdapter.Fill(clientDataTable);

                        if (clientDataTable.Rows.Count > 0)
                        {
                            // Dacă am găsit clientul, returnăm prima (și unica) linie
                            return clientDataTable.Rows[0];
                        }
                        else
                        {
                            // Dacă nu găsim clientul, returnăm null
                            return null;
                        }
                    }
                }
            }
        }
      

    public bool StergeClient(int idClient)
    {
        string connectionString = "User Id=CATANAN_61;Password=stud;Data Source=//193.226.34.57:1521/orclpdb.docker.internal;";

        using (OracleConnection conn = new OracleConnection(connectionString))
        {
            string query = "DELETE FROM p_clienti WHERE CLIENTID = :idClient";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(new OracleParameter("idClient", idClient));

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }


}
}
