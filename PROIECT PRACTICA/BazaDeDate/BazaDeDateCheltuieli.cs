using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PRACTICA.BazaDeDate
{
    public class BazaDeDateCheltuieli
    {


        private string connectionString = "User Id=CATANAN_61;Password=STUD;Data Source=//193.226.34.57:1521/orclpdb.docker.internal;";

        public DataTable GetCheltuieliByCampanieId(int campanieId)
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        CHELTUIALAID,
                        CAMPANIEID,
                        CATEGORIE,
                        SUMA,
                        DATACHELTUIALA,
                        DESCRIERE
                    FROM p_cheltuieli
                    WHERE CAMPANIEID = :campanieId";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":campanieId", campanieId);

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public decimal GetTotalCheltuieliByCampanieId(int campanieId)
        {
            decimal total = 0;
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT SUM(SUMA) FROM p_cheltuieli WHERE CAMPANIEID = :campanieId";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("campanieId", campanieId));

                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    total = Convert.ToDecimal(result);
                }
            }
            return total;
        }

    }
}
