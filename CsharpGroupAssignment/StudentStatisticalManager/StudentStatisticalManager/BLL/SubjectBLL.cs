using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StudentStatisticalManager.DAL.DAO;

namespace StudentStatisticalManager.BLL
{
    class SubjectBLL
    {
        public DataTable GetAllCombo()
        {
            try
            {
                SubjectData dao = new SubjectData();
                return dao.GetAllCombo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return null;
        }
    }
}
