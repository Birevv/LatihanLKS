using CoWorkingSpaceApp.Repositories;
using CoWorkingSpaceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoWorkingSpaceApp.Helpers;
using CoWorkingSpaceApp.Forms;

namespace CoWorkingSpaceApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!");
                return;
            }

            try
            {
                UserRepository userRepo = new UserRepository();
                users loggedInUser = userRepo.Login(email, password);

                if (loggedInUser != null)
                {
                    SessionHelper.CurrentUser = loggedInUser;
                    MessageBox.Show($"Login Berhasil! Selamat Datang, {loggedInUser.name}");

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Gagal! Pastikan email dan password benar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat login: {ex.Message}");
            }
        }
    }
}
