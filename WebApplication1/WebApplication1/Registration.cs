using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1
{
    public class Registration
    {
        public GuestResponse _users;
        private SqlConnection connect = null;
        public void OpenConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
        }
        public void CloseConnection()
        {
            connect.Close();
        }


        public void InsertAuto(int id, string login, string password, string email)
        {
            string sql = string.Format("Insert Into Users" +
                   "(Id, Login, Password, Email) Values(@Id, @Login, @Password, @Email)");

                using (SqlCommand cmd = new SqlCommand(sql, this.connect))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }
            
        }
        public bool GetUsers(string login)
        {
       
            DataTable users = new DataTable();
            string sql = "SELECT Login FROM Users";

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {              
                SqlDataReader dr = cmd.ExecuteReader();
                users.Load(dr);
                dr.Close();                        
            }
           
            return false;
        }
    }
}