using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediScheduler
{
    public partial class HomeA : Form
    {

        public HomeA()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelDoctor.Visible = false;
            panelPatient.Visible = false;
            panelAppointment.Visible = false;
            
        }
        private void hideSubMenu()
        {
            if (panelDoctor.Visible == true)
                panelDoctor.Visible = false;
            if (panelPatient.Visible == true)
                panelPatient.Visible = false;
            if (panelAppointment.Visible == true)
                panelAppointment.Visible = false;
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                hideSubMenu();
                panelMenu.Width = 100;
                //pictureBoxLogo.Visible = false;
                //btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 300;
               // pictureBoxLogo.Visible = true;
                //btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagePatients());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelPatient);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelAppointment);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelDoctor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///Environment.Exit(0);
            Login login = new Login();
            login.Show();
            this.Hide();


        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            openChildForm(new AddAppointment());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageDoctors());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new DoctorListA());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientListA());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            openChildForm(new AppointmentListA());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelMenu);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            //showSubMenu(panelMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
