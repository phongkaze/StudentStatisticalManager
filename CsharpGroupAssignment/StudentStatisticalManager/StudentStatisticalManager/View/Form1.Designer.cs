namespace StudentStatisticalManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGetAllStudent = new MetroFramework.Controls.MetroButton();
            this.dgvStudent = new MetroFramework.Controls.MetroGrid();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMh = new MetroFramework.Controls.MetroTextBox();
            this.txtSotiet = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAllStudent
            // 
            this.btnGetAllStudent.Location = new System.Drawing.Point(77, 68);
            this.btnGetAllStudent.Name = "btnGetAllStudent";
            this.btnGetAllStudent.Size = new System.Drawing.Size(121, 29);
            this.btnGetAllStudent.TabIndex = 2;
            this.btnGetAllStudent.Text = "Get All Student";
            this.btnGetAllStudent.UseSelectable = true;
            this.btnGetAllStudent.Click += new System.EventHandler(this.btnGetAllStudent_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStudent.Location = new System.Drawing.Point(23, 113);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(409, 233);
            this.dgvStudent.TabIndex = 3;
            // 
            // cbMaMH
            // 
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(600, 81);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cbMaMH.TabIndex = 4;
            this.cbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbMaMH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã MH";
            
            // 
            // txtTenMh
            // 
            // 
            // 
            // 
            this.txtTenMh.CustomButton.Image = null;
            this.txtTenMh.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtTenMh.CustomButton.Name = "";
            this.txtTenMh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenMh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenMh.CustomButton.TabIndex = 1;
            this.txtTenMh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenMh.CustomButton.UseSelectable = true;
            this.txtTenMh.CustomButton.Visible = false;
            this.txtTenMh.Lines = new string[0];
            this.txtTenMh.Location = new System.Drawing.Point(600, 134);
            this.txtTenMh.MaxLength = 32767;
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.PasswordChar = '\0';
            this.txtTenMh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenMh.SelectedText = "";
            this.txtTenMh.SelectionLength = 0;
            this.txtTenMh.SelectionStart = 0;
            this.txtTenMh.ShortcutsEnabled = true;
            this.txtTenMh.Size = new System.Drawing.Size(121, 23);
            this.txtTenMh.TabIndex = 6;
            this.txtTenMh.UseSelectable = true;
            this.txtTenMh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenMh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
       
            // 
            // txtSotiet
            // 
            // 
            // 
            // 
            this.txtSotiet.CustomButton.Image = null;
            this.txtSotiet.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtSotiet.CustomButton.Name = "";
            this.txtSotiet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSotiet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSotiet.CustomButton.TabIndex = 1;
            this.txtSotiet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSotiet.CustomButton.UseSelectable = true;
            this.txtSotiet.CustomButton.Visible = false;
            this.txtSotiet.Lines = new string[0];
            this.txtSotiet.Location = new System.Drawing.Point(600, 187);
            this.txtSotiet.MaxLength = 32767;
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.PasswordChar = '\0';
            this.txtSotiet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSotiet.SelectedText = "";
            this.txtSotiet.SelectionLength = 0;
            this.txtSotiet.SelectionStart = 0;
            this.txtSotiet.ShortcutsEnabled = true;
            this.txtSotiet.Size = new System.Drawing.Size(121, 23);
            this.txtSotiet.TabIndex = 8;
            this.txtSotiet.UseSelectable = true;
            this.txtSotiet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSotiet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên MH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số tiết";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSotiet);
            this.Controls.Add(this.txtTenMh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnGetAllStudent);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnGetAllStudent;
        private MetroFramework.Controls.MetroGrid dgvStudent;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtTenMh;
        private MetroFramework.Controls.MetroTextBox txtSotiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

