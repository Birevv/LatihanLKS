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
            LoadSummaryData();
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

                
                // Clear Data
                chart1.Series["Booking"].Points.Clear();
                chart1.Series["Revenue"].Points.Clear();
                chart1.Series["Customer"].Points.Clear();

                // Atur Garis Melengkung
                string[] seriesName = { "Booking", "Revenue", "Customer" };
                foreach (var name in seriesName)
                {
                    var series = chart1.Series[name];
                    series.ChartType = SeriesChartType.Spline;
                    series.BorderWidth = 3;
                }
                chart1.Series["Booking"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                chart1.Series["Customer"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;

                // Atur Warna

                chart1.Series["Booking"].Color = Color.BlueViolet;
                chart1.Series["Revenue"].Color = Color.HotPink;
                chart1.Series["Customer"].Color = Color.DeepSkyBlue;


                // Perlihatkan data pada chart

                chart1.Series["Booking"].Points.DataBindXY(chartData.Select(d => d.LabelX).ToList(), chartData.Select(d => d.TotalBooking).ToList());
                chart1.Series["Revenue"].Points.DataBindXY(chartData.Select(d => d.LabelX).ToList(), chartData.Select(d => d.Revenue).ToList());
                chart1.Series["Customer"].Points.DataBindXY(chartData.Select(d => d.LabelX).ToList(), chartData.Select(d => d.TotalCustomer).ToList());

                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);


            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error loading chart data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSummaryData()
        {
            try
            {
                WorkspaceRepository workspaceRepo = new WorkspaceRepository();
                int totalUser = workspaceRepo.GetTotalUsers();
                int totalRoom = workspaceRepo.GetTotalRooms();

                lb_totaluser.Text = totalUser.ToString();
                lb_totalroom.Text = totalRoom.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data ringkasan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lb_totaluser_Click(object sender, EventArgs e)
        {

        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
           FormBooking bookingForm = new FormBooking();
            bookingForm.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {

        }
    }
}
