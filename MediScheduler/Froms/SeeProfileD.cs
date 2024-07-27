using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediScheduler
{
    public partial class SeeProfileD : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SeeProfileD()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select name,gender,speciality,degree,Picture from DoctorMediScheduler where username='afrin'", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvPatient.DataSource = dataTable;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dgvPatient.Columns[4];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPatient.RowTemplate.Height = 80;
            con.Close();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Username")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Username";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "E-mail")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "E-mail";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
