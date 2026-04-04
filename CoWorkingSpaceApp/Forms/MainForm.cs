using CoWorkingSpaceApp.Helpers;
using CoWorkingSpaceApp.Models;
using CoWorkingSpaceApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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

            LoadDataSpaces();
        }

        private void LoadDataSpaces()
        {
            try
            {
                WorkspaceRepository workspaceRepo = new WorkspaceRepository();
                var data = workspaceRepo.GetAllSpaces();
                dgv_dashboard.DataSource = data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading spaces: " + ex.Message);
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

        private void chart1_Click(object sender, EventArgs e)
        {
    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_booking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
