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
    public partial class HomeD : Form
    {
        public HomeD()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelProfile.Visible = false;
            panelSchedule.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelProfile.Visible == true)
                panelProfile.Visible = false;
            if (panelSchedule.Visible == true)
                panelSchedule.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfile);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSchedule);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ///Environment.Exit(0);
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateScheduleD());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new SeeScheduleD());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientListA());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileUpdateD());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new SeeProfileD());
        }
    }
}
