using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinData
{
    public class KorisnikRepository : Shared.Interfaces.IKorisnikRepository
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
    }
}
