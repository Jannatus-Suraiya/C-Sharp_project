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
    public partial class HomeP : Form
    {
        public HomeP()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelPProfile.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelPProfile.Visible == true)
                panelPProfile.Visible = false; 
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                HideSubMenu();
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
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }
        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
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

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void HomeP_Load(object sender, EventArgs e)
        {
           showSubMenu(panelMenu);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelPProfile);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileUpdateP());
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SeeProfileDP());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SeeScheduleD());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AddAppointment());
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PaymentP());
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            ///Environment.Exit(0);
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            showSubMenu(panelMenu);
        }
    }
}
