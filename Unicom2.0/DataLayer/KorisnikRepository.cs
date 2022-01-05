using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KorisnikRepository
    {
        
        public List<Korisnik> GetAllKorisnik()
        {
            List<Korisnik> korisnikList = new List<Korisnik>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Korisnik";


                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Korisnik korisnik = new Korisnik();
                    korisnik.Id = dataReader.GetInt32(0);
                    korisnik.Username = dataReader.GetString(1);
                    korisnik.First_Name = dataReader.GetString(2);
                    korisnik.Last_Name = dataReader.GetString(3);
                    

                    korisnikList.Add(korisnik);
                }
            }

            return korisnikList;
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

        public int UpdateItem(Korisnik korisnik)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                string sqlCommand = "UPDATE Items SET Username = @Username, First_Name = @First_Name, Last_Name = @Last_Name WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", korisnik.Id);
                command.Parameters.AddWithValue("@Username", korisnik.Username);
                command.Parameters.AddWithValue("@First_Name", korisnik.First_Name);
                command.Parameters.AddWithValue("@Last_Name", korisnik.Last_Name);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteItem(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Items WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }

    }
}
