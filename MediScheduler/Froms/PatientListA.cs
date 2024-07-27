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
    public partial class PatientListA : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public PatientListA()
        {
            InitializeComponent();
        }

        private void PatientListA_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select name,age,gender,dateOfBirth,bloodGroup,Email,Mobno,Picture from PatientMediScheduler /*where username='rafi1'*/", con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvPatientlist1.DataSource = dataTable;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dgvPatientlist1.Columns[7];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvPatientlist1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPatientlist1.RowTemplate.Height = 80;
            con.Close();
        }
    }
}
