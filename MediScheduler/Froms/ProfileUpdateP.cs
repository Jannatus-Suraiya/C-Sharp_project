using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;

namespace MediScheduler
{
    public partial class ProfileUpdateP : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public ProfileUpdateP()
        {
            InitializeComponent();
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.GetBuffer();
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            dateTimePicker1.ResetText();
            numericUpDown1.Value = 0;
            //pictureBox2.Image.Dispose();
            pictureBox2.Image = Properties.Resources.no_image_avaiable;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG FILE (*.PNG) | *.PNG";
            ofd.Filter = "ALL IMAGE FILE (*.*) | *.*";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into PatientMediScheduler (name, userName, password, age, gender, dateOfBirth, bloodGroup, email, mobNo, picture) values (@name, @userName, @password, @age, @gender, @dateOfBirth, @bloodGroup, @email, @mobNo, @picture)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@userName", textBox7.Text);
            cmd.Parameters.AddWithValue("@password", textBox8.Text);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@gender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@bloodGroup", comboBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@mobNo", textBox6.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

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

        private void button1_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
