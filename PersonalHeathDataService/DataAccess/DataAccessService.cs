using PersonalHeathDataService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonalHeathDataService.DataAccess
{
    public class DataAccessService : IDataAccessService
    {
        private string connectionString = null;

        public DataAccessService()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PHDConnectionDB"].ConnectionString;
        }

        public UserInfo GetUser(string uid)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand { Connection = connection };
                cmd.CommandText = "SELECT UR.Uid, UR.Password, UR.FirstName, UR.MiddleName, UR.LastName, UR.Dob, CO.Name CountryName, CO.SName, UR.Phone, UR.Cell, UR.Email FROM Users UR INNER JOIN Country CO ON UR.Country = CO.Id WHERE UR.Uid = '" + uid + "'";
                cmd.CommandType = CommandType.Text;

                var reader = cmd.ExecuteReader();

                var user = new UserInfo();
                while (reader.Read())
                {
                    user.Uid = reader["Uid"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.FirstName = reader["FirstName"].ToString();
                    user.MiddleName = reader["MiddleName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                }

                return user;
            }
        }
    }
}