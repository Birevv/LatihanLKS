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
            LoadDataChart();
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

        private void LoadDataChart()
        {
            try
            {
                // Panggil data dari database
                WorkspaceRepository workspaceRepo = new WorkspaceRepository();
                var chartData = workspaceRepo.GetStatisticsData();

                // 1. Bersihkan titik data lama agar tidak menumpuk
                chart1.Series["Booking"].Points.Clear();
                chart1.Series["Revenue"].Points.Clear();
                chart1.Series["Customer"].Points.Clear();

                // 2. Ubah tipe garis menjadi melengkung halus (Spline)
                chart1.Series["Booking"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series["Revenue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series["Customer"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                // 3. Pertebal garis agar lebih jelas seperti gambar referensi
                chart1.Series["Booking"].BorderWidth = 2;
                chart1.Series["Revenue"].BorderWidth = 2;
                chart1.Series["Customer"].BorderWidth = 2;

                // 4. Pisahkan penggaris: Sumbu Y Kanan untuk Booking & Customer (karena angkanya kecil)
                chart1.Series["Booking"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                chart1.Series["Customer"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                chart1.Series["Revenue"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;

                // 5. Masukkan data ke masing-masing garis
                foreach (var item in chartData)
                {
                    chart1.Series["Booking"].Points.AddXY(item.LabelX, item.TotalBooking);
                    chart1.Series["Revenue"].Points.AddXY(item.LabelX, item.Revenue);
                    chart1.Series["Customer"].Points.AddXY(item.LabelX, item.TotalCustomer);
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error loading chart data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
