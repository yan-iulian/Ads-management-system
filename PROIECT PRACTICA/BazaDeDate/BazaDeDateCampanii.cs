using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PRACTICA.BazaDeDate
{
    public class BazaDeDateCampanii
    {
        private string connectionString = "User Id=CATANAN_61;Password=STUD;Data Source=//193.226.34.57:1521/orclpdb.docker.internal;";

        public DataRow GetCampanieActivaByClientId(int clientId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM p_campanii WHERE clientid = :clientId";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("clientId", clientId));

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                        return table.Rows[0];
                    else
                        return null;
                }
            }
        }


        public bool ExistaCampaniePentruClient(int idClient)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM p_campanii WHERE clientid = :idClient";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("idClient", idClient));

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Dacă există cel puțin o campanie pentru client, returnăm true
                    return count > 0;
                }
            }
        }

        public DataRow GetCampanieByClientId(int idClient)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DENUMIRECAMPANIE, DATASTART, DATASFARSIT, BUGETTOTAL FROM p_campanii WHERE clientid = :idClient";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("idClient", idClient));

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable campanieTable = new DataTable();
                    adapter.Fill(campanieTable);

                    if (campanieTable.Rows.Count > 0)
                        return campanieTable.Rows[0];
                    else
                        return null;
                }
            }
        }

        public int GetNrProduseInCampanie(int idClient)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                // Interogăm tabelul p_campanii pentru a obține idCampanie asociat clientului
                string queryCampanie = "SELECT CampanieID FROM p_campanii WHERE clientid = :idClient";

                using (OracleCommand commandCampanie = new OracleCommand(queryCampanie, connection))
                {
                    commandCampanie.Parameters.Add(new OracleParameter("idClient", idClient));

                    // Executăm interogarea și obținem idCampanie
                    int idCampanie = Convert.ToInt32(commandCampanie.ExecuteScalar());

                    if (idCampanie > 0)
                    {
                        // Acum că avem idCampanie, interogăm p_campanii_produse pentru a număra produsele asociate
                        string queryProduse = "SELECT COUNT(*) FROM p_campanii_produse WHERE campanieID = :idCampanie";

                        using (OracleCommand commandProduse = new OracleCommand(queryProduse, connection))
                        {
                            commandProduse.Parameters.Add(new OracleParameter("idCampanie", idCampanie));

                            // Executăm interogarea și obținem numărul de produse
                            int nrProduse = Convert.ToInt32(commandProduse.ExecuteScalar());
                            return nrProduse; // Returnăm numărul de produse
                        }
                    }
                    else
                    {
                        // Dacă nu există o campanie pentru client, returnăm 0
                        return 0;
                    }
                }
            }
        }

        public int? GetCampanieIdByClientId(int clientId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT CAMPANIEID FROM p_campanii WHERE CLIENTID = :clientId FETCH FIRST 1 ROWS ONLY";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("clientId", clientId));

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToInt32(result);

                return null;
            }
        }
    }
}
