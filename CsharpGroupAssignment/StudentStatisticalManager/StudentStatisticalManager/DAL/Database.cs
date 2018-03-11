using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatisticalManager.DAL
{
    public static class Database
    {
        public static string getConnectionString()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            return strConnection;
        }

        public static DataSet ExecuteQueryWithDataSet(string sql, CommandType cmdType, params SqlParameter[] param)
        {
            using (SqlConnection cnn = new SqlConnection(getConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = cmdType;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds; 
            }
        }


        public static SqlDataReader ExecuteQueryWithDataReader(string sql, CommandType cmdType, params SqlParameter[] param)
        {
            SqlDataReader rd = null;
            using (SqlConnection cnn = new SqlConnection(getConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(param);

                try
                {
                    cnn.Open();
                    rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }

                return rd;                 
            }            
        }

        public static bool ExecuteNonQuery(string strSQL,
        CommandType cmdType, params SqlParameter[] paramList)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(paramList);
            try
            {
                cnn.Open();
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
    }
}
