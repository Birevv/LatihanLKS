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
                lbWelcome.Text = $"Welcome, {SessionHelper.CurrentUser.name}!";

                if (SessionHelper.CurrentUser.role == "Customer")
                {
                    btn_MasterWorkspace.Visible = false;
                }
                else if (SessionHelper.CurrentUser.role == "Admin")
                {
                    btn_MasterWorkspace.Visible = true;
                }
            }
            else
            {
                lbWelcome.Text = "Welcome, Guest";
                btn_MasterWorkspace.Visible = false;
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
    }
}
