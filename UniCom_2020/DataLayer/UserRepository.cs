﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UniComDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM User";


                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    User user = new User();
                    user.UserID = dataReader.GetInt32(0);
                    user.username = dataReader.GetString(1);
                    user.First_Name = dataReader.GetString(2);
                    user.Last_Name = dataReader.GetString(3);
                    user.Gender = dataReader.GetBoolean(4);
                    user.Mentor = dataReader.GetBoolean(5);
                    user.Administration = dataReader.GetBoolean(6);
                    user.Profession = dataReader.GetString(7);
                    user.Year_of_Birth = dataReader.GetInt32(8);
                    userList.Add(user);
                }
            }

            return userList;
        }

        public int InsertUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO User VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'.'{8}')",
                user.UserID, user.username, user.First_Name, user.Last_Name, user.Gender, user.Mentor, user.Administration, user.Profession, user.Year_of_Birth);

                return command.ExecuteNonQuery();
            }
        }
    }
}
