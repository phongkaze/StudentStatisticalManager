using StudentStatisticalManager.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatisticalManager.BLL
{
    public class StudentBLL
    {
        public DataTable GetAllStudent()
        {
            try
            {
                StudentData dao = new StudentData();
                return dao.GetAllStudent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return null; 
        }
       
    }
}
