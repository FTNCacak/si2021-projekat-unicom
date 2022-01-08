using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;
using Shared.Models;

namespace UnicomData
{
    public class KorisnikRepository : IKorisnikRepository
    {
        public List<Korisnik> GetAllKorisnik()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = Constants.connString;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT * FROM Korisnik";

            SqlDataReader dataReader = command.ExecuteReader();


            List<Korisnik> listOfKorisnik = new List<Korisnik>();

            while (dataReader.Read())
            {
                Korisnik korisnik = new Korisnik();
                korisnik.Id = dataReader.GetInt32(0);
                korisnik.Username = dataReader.GetString(1);
                korisnik.First_Name = dataReader.GetString(2);
                korisnik.Last_Name = dataReader.GetString(3);

                listOfKorisnik.Add(korisnik);
            }

            sqlConnection.Close();

            return listOfKorisnik;
        }

        public int InsertKorisnik(Korisnik korisnik)
        {
            // Postoji lakši način za konektovanje na bazu i automatsko zatvaranje konekcije
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Korisnik VALUES('{0}','{1}','{2}')",
                    korisnik.Username, korisnik.First_Name, korisnik.Last_Name);

                return command.ExecuteNonQuery();
            }


        }

        public int UpdateKorisnik(Korisnik korisnik)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                string sqlCommand = "UPDATE Korisnik SET Username = @Username, First_Name = @First_Name, Last_Name = @Last_Name WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", korisnik.Id);
                command.Parameters.AddWithValue("@Username", korisnik.Username);
                command.Parameters.AddWithValue("@First_Name", korisnik.First_Name);
                command.Parameters.AddWithValue("@Last_Name", korisnik.Last_Name);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteKorisnik(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Korisnik WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }
    }
}
