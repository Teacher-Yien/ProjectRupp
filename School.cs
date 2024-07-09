using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shcool_management
{
    public partial class School : Form
	{
		

		public School()
        {
            
            InitializeComponent();
            CustomDesign();
			
		}

		private void School_Load(object sender, EventArgs e)
		{
			PerformLogin();
		}

		private void PerformLogin()
		{
			Login loginForm = new Login();
			if (loginForm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("Welcome to the main school system!", "Main Form");
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				Application.Exit(); // Close application on failed login
			}
		}

		private void CustomDesign()
        {
            panelHomeSubMenu.Visible = false;
            panelAtandentSumMenu.Visible = false;
            panelPaymentSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if(panelHomeSubMenu.Visible == true) panelHomeSubMenu.Visible = false;
            if(panelAtandentSumMenu.Visible == true) panelAtandentSumMenu.Visible = false;
            if (panelPaymentSubMenu.Visible == true) panelPaymentSubMenu.Visible = false; 

        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }else subMenu.Visible = false;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHomeSubMenu);
        }

        private void btn_Atandent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAtandentSumMenu);
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPaymentSubMenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnStaff_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new Staff());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new Students());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Class());
        }

        private void btn_sub_payments_Click(object sender, EventArgs e)
        {
            openChildForm(new Payments());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new user());
        }

		private void logout_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		
	}
}
