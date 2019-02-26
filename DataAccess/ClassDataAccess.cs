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
    public class ClassDataAccess
    {
        private SqlConnection sqlCon = null;
        public ClassDataAccess()
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
        public string insertClass(Class c)
        {
            // Note the "placeholders" in the SQL query.  
            string sql = "Insert Into Class(ClassId, ClassName, Venue) Values(@ClassId, @ClassName, @Venue)";
            // This command will have internal parameters.  
            string result = "";
            using (SqlCommand command = new SqlCommand(sql, sqlCon))
            {
                // Fill params collection.    
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@ClassId",
                    Value = c.ClassId,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@ClassName",
                    Value = c.ClassName,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Venue",
                    Value = c.Venue,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                //command.ExecuteNonQuery();
                try
                {
                    result = command.ExecuteScalar().ToString();
                }
                catch(Exception e)
                {

                }
            }
            return result;
        }

    }
}