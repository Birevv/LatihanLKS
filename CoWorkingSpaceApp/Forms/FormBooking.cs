using CoWorkingSpaceApp.Repositories;
using CoWorkingSpaceApp.UsersControl;
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
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            WorkspaceRepository WorkspaceRepo = new WorkspaceRepository();
            var roomList = WorkspaceRepo.GetAllRooms(); 
            flprooms.Controls.Clear();

           foreach (var room in roomList)
            {
                RoomCardControl card = new RoomCardControl();
                card.RoomId = room.room_id;
                card.RoomName = room.name;
                card.RoomType = room.type;

                card.amenities = $"Capacity: {room.capacity}, Equipment: {room.equipment}";
                card.price = "Rp" + room.price.ToString("0") + "/Jam";

                card.Margin = new Padding(10);
                card.Click += Card_Click;

                flprooms.Controls.Add(card);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            RoomCardControl selectedCard = sender as RoomCardControl;
            if (selectedCard != null)
            {
                int roomId = selectedCard.RoomId;
                MessageBox.Show($"Anda memilih ruangan: {selectedCard.RoomName} (ID: {roomId})");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void FormBooking_Load(object sender, EventArgs e)
        {

        }

        private void flpRooms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_roomImage_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flprooms_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}