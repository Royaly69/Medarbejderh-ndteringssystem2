using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejderhåndteringssystem
{
    internal class ConnectionDB
    {
        public string connectionString = "Server = DESKTOP-ROYALY; Database = MedarbejderDB; Trusted_Connection = True";

        public ConnectionDB() { }

        public void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void CreateUser(User us)
        {
            ConnectionDB conn = new ConnectionDB();
            string query = us.CreateQueryString();
            conn.CreateCommand(query, conn.connectionString);

        }
        public void DeleteUser(User us)
        {
            ConnectionDB conn = new ConnectionDB();
            string query = us.DeleteQueryString();
            conn.CreateCommand(query, conn.connectionString);
        }
        public User ReadDB(int row)
        {
            User user = new User();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand command = sqlConnection.CreateCommand();

            string sql = $"SELECT * FROM (SELECT ROW_NUMBER() OVER (Order BY UserID ASC) AS rownumber,* FROM Users)AS foo Where rownumber ={row}";
            SqlCommand readCommand = sqlConnection.CreateCommand();
            command.CommandText = sql;

            //readCommand.Parameters.AddWithValue("@UserID", 1);

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Fornavn = reader.GetString(2);
                    user.Efternavn = reader.GetString(3);
                    user.Alder = reader.GetInt32(4);
                    user.Email = reader.GetString(5);
                    user.TelefonNummer = reader.GetInt32(6);
                }
                sqlConnection.Close();
            }
            return user;
        }

        public int GetTableLength()
        {
            int Length=0;
            User user = new User();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand command = sqlConnection.CreateCommand();

            string sql = $"SELECT COUNT(1) FROM Users;";
            SqlCommand readCommand = sqlConnection.CreateCommand();
            command.CommandText = sql;

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Length = reader.GetInt32(0);
                }
                sqlConnection.Close();
            }
            return Length;
        }

        
    }

}
