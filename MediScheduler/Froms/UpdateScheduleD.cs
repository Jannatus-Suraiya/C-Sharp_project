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
    public partial class UpdateScheduleD : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public UpdateScheduleD()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select PatientuserName, docname, appointedtime from Appointment";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 80;
        }
        void ResetControl()
        {
            dateTimePicker1.ResetText();
            textBox4.Clear();
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateScheduleD_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if(textBox4.Text== "Patient Username")
            { textBox4.Text = "";
            textBox4.ForeColor = Color.Black;}
        }

        private void textBox4_Leave_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Patient Username";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "Doctor Name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Appointment(PatientuserName, docname, appointedtime) values (@PatientuserName, @docname,  @appointedtime)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PatientuserName", textBox4.Text);
            cmd.Parameters.AddWithValue("@docname", textBox3.Text);
            cmd.Parameters.AddWithValue("@appointedtime", dateTimePicker1.Value);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update Appointment set PatientuserName=@PatientuserName, docname=@docname, appointedtime=@appointedtime where PatientuserName=@PatientuserName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PatientuserName", textBox4.Text);
            cmd.Parameters.AddWithValue("@docname", textBox3.Text);
            cmd.Parameters.AddWithValue("@appointedtime", dateTimePicker1.Value);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Updated");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from Appointment where PatientuserName=@PatientuserName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PatientuserName", textBox4.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Deleted");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Doctor Name";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
