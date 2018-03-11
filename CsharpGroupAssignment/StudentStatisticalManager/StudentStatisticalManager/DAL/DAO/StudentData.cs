using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatisticalManager.DAL.DAO
{
    public class StudentData
    {
        DataTable dt = new DataTable();
        public DataTable GetAllStudent()
        {
            string sql = "Select * from SVIEN";

            DataSet dsStudent = new DataSet(); 

            try
            {
                dsStudent = Database.ExecuteQueryWithDataSet(sql, CommandType.Text);
                dt = dsStudent.Tables[0];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
       
       

    }
}
