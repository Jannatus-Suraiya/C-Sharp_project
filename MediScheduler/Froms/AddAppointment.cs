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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediScheduler
{
    public partial class AddAppointment : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AddAppointment()
        {
            InitializeComponent();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Appointment(PatientuserName, docname, speciality, appointedtime, Paiprob) values (@PatientuserName, @docname, @speciality, @appointedtime, @Paiprob)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PatientuserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@docname", textBox2.Text);
            cmd.Parameters.AddWithValue("@speciality", comboBox1.Text);
            cmd.Parameters.AddWithValue("@appointedtime", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Paiprob", textBox3.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Saved Successfully");
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Saved");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}
