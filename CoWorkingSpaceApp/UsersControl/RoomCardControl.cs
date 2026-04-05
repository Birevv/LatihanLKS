using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoWorkingSpaceApp.UsersControl
{
    public partial class RoomCardControl : UserControl
    {
        public RoomCardControl()
        {
            InitializeComponent();
        }

        public int RoomId { get; set; }
        public string RoomName
        {
            get { return lbl_roomName.Text; }
            set { lbl_roomName.Text = value; }
        }

        public string RoomType
        {
            get { return lbl_type.Text; }
            set { lbl_type.Text = value; }  
        }

        public string amenities
        {
            get { return lbl_amenities.Text; }
            set { lbl_amenities.Text = value; }
        }

        public string price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }
        }
        
        public Image RoomImage
        {
            get { return pb_roomImage.Image; }
            set { pb_roomImage.Image = value; }
        }

        private void RoomCardControl_Load(object sender, EventArgs e)
        {

        }

        private void pb_roomImage_Click(object sender, EventArgs e)
        {

        }

        private void lbl_type_Click(object sender, EventArgs e)
        {

        }

        private void lbl_roomName_Click(object sender, EventArgs e)
        {

        }
    }
}
