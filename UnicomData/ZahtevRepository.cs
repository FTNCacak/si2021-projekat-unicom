using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomData
{
    public class ZahtevRepository : IZahtevRepository
    {
        public List<Zahtev> GetAllZahtev()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = Constants.connString;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT * FROM Zahtev";

            SqlDataReader dataReader = command.ExecuteReader();


            List<Zahtev> listOfZahtev = new List<Zahtev>();

            while (dataReader.Read())
            {
                Zahtev zahtev = new Zahtev();
                zahtev.Id = dataReader.GetInt32(0);
                zahtev.Title = dataReader.GetString(1);
                zahtev.Description = dataReader.GetString(2);
                zahtev.UserId = dataReader.GetInt32(3);

                listOfZahtev.Add(zahtev);
            }

            sqlConnection.Close();

            return listOfZahtev;
        }

        public int InsertZahtev(Zahtev zahtev)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Zahtev VALUES('{0}','{1}','{2}')",
                zahtev.Title, zahtev.Description, zahtev.UserId);

                return command.ExecuteNonQuery();
            }


        }

        public int UpdateZahtev(Zahtev zahtev)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                string sqlCommand = "UPDATE Zahtev SET Title = @Title, Description = @Description, UserId = @UserId WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", zahtev.Id);
                command.Parameters.AddWithValue("@Title", zahtev.Title);
                command.Parameters.AddWithValue("@Description", zahtev.Description);
                command.Parameters.AddWithValue("@UserId", zahtev.UserId);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteZahtev(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Zahtev WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }
    }
}
