using CoWorkingSpaceApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoWorkingSpaceApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (SessionHelper.CurrentUser != null)
            {
                lbWelcome.Text = SessionHelper.CurrentUser.name;
                ;

                if (SessionHelper.CurrentUser.role == "Customer")
                {
                    panel4.Visible = false;
                    label4.Text = "Dashboard";
                }
                else if (SessionHelper.CurrentUser.role == "Admin")
                {
                    btn_MasterWorkspace.Visible = true;
                    label4.Text = "Dashboard Admin";

                }
            }
        }
        

        private void btn_MasterWorkspace_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_Dashboard_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
