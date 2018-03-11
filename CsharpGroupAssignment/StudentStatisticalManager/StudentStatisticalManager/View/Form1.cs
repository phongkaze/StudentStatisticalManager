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
                DataTable dt = subjectBll.GetAllCombo();
                foreach (DataRow row in dt.Rows)
                {
                    this.cbMaMH.Items.Add(row.ItemArray[0]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mamh = this.cbMaMH.SelectedItem.ToString();
            SubjectBLL subjectBll = new SubjectBLL();
            DataTable dt1 = subjectBll.GetTENMH(mamh);
            DataTable dt2 = subjectBll.GetSOTIET(mamh);
            DataRow row1 = dt1.Rows[0];
            DataRow row2 = dt2.Rows[0];
            if (row1 != null && row2 != null)
            {
                this.txtTenMh.Text = (string)row1.ItemArray[0];
                this.txtSotiet.Text = row2.ItemArray[0].ToString();
            }
        }
    }
}
