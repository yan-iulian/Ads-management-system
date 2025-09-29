using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace PROIECT_PRACTICA.BazaDeDate
{
    public class BazaDeDateUtilizatori
    {
        
        private string connectionString;

        public BazaDeDateUtilizatori()
        {
            connectionString = "User Id=CATANAN_61;Password=STUD;Data Source=//193.226.34.57:1521/orclpdb.docker.internal;";
        }

        
        private OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

      //metoda pentru validarea utilizatorului
        public bool ValidateUser(string username, string password)
        {
            using (OracleConnection connection = GetConnection())
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT COUNT(*) FROM p_utilizatori WHERE Username = :username AND Parola = :password";
                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter(":username", username));  
                    command.Parameters.Add(new OracleParameter(":password", password));  

                    
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    
                    return result > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la validarea utilizatorului: " + ex.Message);
                    return false;
                }
            }
        }

        // Metodă pentru a obține detalii despre un utilizator pe baza username-ului
        public DataTable GetUserDetails(string username)
        {
            using (OracleConnection connection = GetConnection())
            {
                try
                {
                    
                    connection.Open();

                  
                    string query = "SELECT * FROM p_utilizatori WHERE Username = :username";
                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter(":username", username));  

                   
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la obținerea detaliilor utilizatorului: " + ex.Message);
                    return null;
                }
            }
        }

        public string GetNumeComplet(string username)
        {
            using (OracleConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT  NumeComplet FROM p_utilizatori WHERE Username = :username";
                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter(":username", username));

                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : "Utilizator Necunoscut";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la obținerea numelui complet: " + ex.Message);
                    return "Utilizator Necunoscut";
                }
            }
        }

        public string GetRol(string username)
        {
            using (OracleConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Rol FROM p_utilizatori WHERE Username = :username";
                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter(":username", username));

                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : "Utilizator Necunoscut";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la obținerea rolului: " + ex.Message);
                    return "Utilizator Necunoscut";
                }
            }
        }


        

    }
}
