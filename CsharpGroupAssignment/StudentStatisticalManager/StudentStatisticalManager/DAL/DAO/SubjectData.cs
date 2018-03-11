using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentStatisticalManager.DAL.DAO
{
    class SubjectData
    {
        DataTable dt = new DataTable();
        public DataTable GetAllCombo()
        {

            string sql = "Select MAMH from MHOC";
            DataSet dsSubject = new DataSet();
            try
            {
                dsSubject = Database.ExecuteQueryWithDataSet(sql, CommandType.Text);
                dt = dsSubject.Tables[0];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
      
    }
}
