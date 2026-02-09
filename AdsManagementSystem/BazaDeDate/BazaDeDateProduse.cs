using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PROIECT_PRACTICA.BazaDeDate
{
    public class BazaDeDateProduse
    {

        private string connectionString = "User Id=CATANAN_61;Password=STUD;Data Source=//193.226.34.57:1521/orclpdb.docker.internal;";

        public DataTable GetProduseByCampanieId(int campanieId)
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = @"
                SELECT 
                    p.PRODUSID, 
                    p.NUMEPRODUS, 
                    p.TIPPRODUS, 
                    p.PRETUNITAR, 
                    cp.CANTITATE
                FROM p_campanii_produse cp
                INNER JOIN p_produse p ON p.PRODUSID = cp.PRODUSID
                WHERE cp.CAMPANIEID = :campanieId";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("campanieId", campanieId));

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        public DataTable GetToateProdusele()
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT PRODUSID, NUMEPRODUS, TIPPRODUS, PRETUNITAR FROM p_produse";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        public int GetUltimulProdusId()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT MAX(PRODUSID) FROM p_produse";
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        public bool AdaugaProdus(string numeProdus, string tipProdus, decimal pretUnitar)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "INSERT INTO p_produse (PRODUSID, NUMEPRODUS, TIPPRODUS, PRETUNITAR) " +
                               "VALUES (:produsId, :numeProdus, :tipProdus, :pretUnitar)";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":produsId", OracleDbType.Int32).Value = GetUltimulProdusId() + 1;
                cmd.Parameters.Add(":numeProdus", OracleDbType.Varchar2).Value = numeProdus;
                cmd.Parameters.Add(":tipProdus", OracleDbType.Varchar2).Value = tipProdus;
                cmd.Parameters.Add(":pretUnitar", OracleDbType.Decimal).Value = pretUnitar;

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


        public bool StergeProdus(int produsId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "DELETE FROM p_produse WHERE PRODUSID = :produsId";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("produsId", produsId));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }


    }
}
