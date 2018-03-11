using StudentStatisticalManager.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace StudentStatisticalManager
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGetAllStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentBLL studentBll = new StudentBLL();
                this.dgvStudent.DataSource = studentBll.GetAllStudent();
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SubjectBLL subjectBll = new SubjectBLL();
                DataSet ds = new DataSet();
                DataTable dt = subjectBll.GetAllCombo();
               
                foreach(DataRow row in dt.Rows)
                {
                    this.cbMaMH.Items.Add(row.ItemArray[0]);
                }
                
            }
            catch
            {

            }
        }
    }
}
