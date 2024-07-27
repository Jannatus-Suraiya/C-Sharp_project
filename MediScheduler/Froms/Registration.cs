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
    public partial class Registration : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Registration()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into UserMediScheduler (userName, name, email, password, role) values (@userName,@name,@email,@password,@role)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@userName", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            if (radioButton2.Checked == true)
            { cmd.Parameters.AddWithValue("@role", radioButton2.Text); }
            else if(radioButton3.Checked==true)
            { cmd.Parameters.AddWithValue("@role", radioButton3.Text); }


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
            con.Close();

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
