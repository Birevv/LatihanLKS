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

namespace CoWorkingSpaceApp.Forms
{
    public partial class FormTransactions : Form
    {
        private int _roomId;
        private int _hargaPerJam;

        public FormTransactions(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
        }

        private void FormTransactions_Load_1(object sender, EventArgs e)
        {
            WorkspaceRepository workspaceRepo = new WorkspaceRepository();
            RoomViewModel dataRuangan = workspaceRepo.GetRoomById(_roomId);

            if (dataRuangan != null)
            { 
                lbl_type.Text = dataRuangan.type;
                lbl_roomName.Text = dataRuangan.name;

                lbl_amenities.Text = dataRuangan.capacity.ToString() + " Guests";
                lbl_subtotal.Text = "Rp. " + dataRuangan.price.ToString("N0");

                _hargaPerJam = dataRuangan.price;
                NudDurasi.Value = 1;
                HitungTotalHarga();

            }
            else
            {
                MessageBox.Show(ToString(), "Data Ruangan Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void HitungTotalHarga()
        {
            decimal durasiJam = NudDurasi.Value;
            decimal subTotal = _hargaPerJam * durasiJam;

            decimal diskon = 15000;
            decimal serviceFee = 25000;

            decimal totalAkhir = subTotal - diskon + serviceFee;
            
            lbl_subtotal.Text = "Rp. " + subTotal.ToString("N0");
            lbl_totalPrice.Text = "Rp. " + totalAkhir.ToString("N0");

            lbl_durasi.Text = $"Price x {durasiJam} Jam";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void linklbl_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBooking formBooking = new FormBooking();
            formBooking.Show();
            this.Hide();
        }

        private void pb_roomImage_Click(object sender, EventArgs e)
        {

        }

        private void lbl_roomName_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NudDurasi_ValueChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }

        private void lbl_amenities_Click(object sender, EventArgs e)
        {

        }

        private void lbl_subtotal_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Harap isi semua data diri (Nama, Whatsapp, dan Email) Sebelum Melakukan Pembayaran !", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                MessageBox.Show("Semua data valid! Siap untuk disimpan ke database.", "Validasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaf Terjadi Kesalahan Saat Memproses Data: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
