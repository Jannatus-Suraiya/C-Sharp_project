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
    public partial class PaymentP : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public PaymentP()
        {
            InitializeComponent();
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox5.Clear();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtpatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into payment (username, AppointedDate, PaymentDate, ReceiptNo ,CardNo ,Amount,Password) values (@username, @AppointedDate, @PaymentDate, @ReceiptNo ,@CardNo ,@Amount,@Password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtpatientID.Text);
            cmd.Parameters.AddWithValue("@AppointedDate", dateTimePicker3.Text);
            cmd.Parameters.AddWithValue("@PaymentDate", dateTimePicker4.Value);
            cmd.Parameters.AddWithValue("@ReceiptNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@CardNo", textBox4.Text);
            cmd.Parameters.AddWithValue("@Amount", textBox5.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Bill Paid Successfully");
                ResetControl();
            }
            else
            {
                MessageBox.Show("Bill Not Paid");
            }
        }

        private void txtpatientID_Enter(object sender, EventArgs e)
        {
            if (txtpatientID.Text == "Patient Username")
            {
                txtpatientID.Text = "";
                txtpatientID.ForeColor = Color.Black;
            }
        }

        private void txtpatientID_Leave(object sender, EventArgs e)
        {
            if (txtpatientID.Text == "")
            {
                txtpatientID.Text = "Patient Username";
                txtpatientID.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}
