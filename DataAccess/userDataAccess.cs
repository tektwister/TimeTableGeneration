using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TimeTable.Models;

namespace TimeTable.DataAccess
{
    public class userDataAccess
    {
        private SqlConnection sqlCon = null;
        public userDataAccess()
        {
            //this.OpenConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            this.OpenConnection(ConfigurationManager.ConnectionStrings["TimeTableConnection"].ToString());
        }
        public void OpenConnection(string conStr)
        {
            sqlCon = new SqlConnection { ConnectionString = conStr };
            sqlCon.Open();
        }
        public void CloseConnection()
        {
            sqlCon.Close();
        }
        public string insertClass(user u)
        {
            // Note the "placeholders" in the SQL query.  
            string sql = "Insert Into user(name, username, password) Values(@name, @username, @password)";
            // This command will have internal parameters.  
            string result = "";
            using (SqlCommand command = new SqlCommand(sql, sqlCon))
            {
                // Fill params collection.    
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = u.name,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@username",
                    Value = u.username,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@password",
                    Value = u.password,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                //command.ExecuteNonQuery();
                try
                {
                    result = command.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {

                }
            }
            return result;
        }

    }
}