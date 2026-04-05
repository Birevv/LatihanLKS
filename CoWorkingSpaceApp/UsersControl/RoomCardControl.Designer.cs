namespace CoWorkingSpaceApp.UsersControl
{
    partial class RoomCardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomCardControl));
            this.pb_roomImage = new System.Windows.Forms.PictureBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_roomName = new System.Windows.Forms.Label();
            this.lbl_amenities = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_roomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_roomImage
            // 
            this.pb_roomImage.Image = ((System.Drawing.Image)(resources.GetObject("pb_roomImage.Image")));
            this.pb_roomImage.Location = new System.Drawing.Point(28, 17);
            this.pb_roomImage.Name = "pb_roomImage";
            this.pb_roomImage.Size = new System.Drawing.Size(250, 160);
            this.pb_roomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_roomImage.TabIndex = 0;
            this.pb_roomImage.TabStop = false;
            this.pb_roomImage.Click += new System.EventHandler(this.pb_roomImage_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(293, 17);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(49, 20);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "J Type";
            this.lbl_type.Click += new System.EventHandler(this.lbl_type_Click);
            // 
            // lbl_roomName
            // 
            this.lbl_roomName.AutoSize = true;
            this.lbl_roomName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomName.Location = new System.Drawing.Point(293, 49);
            this.lbl_roomName.Name = "lbl_roomName";
            this.lbl_roomName.Size = new System.Drawing.Size(271, 23);
            this.lbl_roomName.TabIndex = 2;
            this.lbl_roomName.Text = " Semi Private Co-Working Space";
            this.lbl_roomName.Click += new System.EventHandler(this.lbl_roomName_Click);
            // 
            // lbl_amenities
            // 
            this.lbl_amenities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amenities.Location = new System.Drawing.Point(293, 87);
            this.lbl_amenities.Name = "lbl_amenities";
            this.lbl_amenities.Size = new System.Drawing.Size(355, 61);
            this.lbl_amenities.TabIndex = 3;
            this.lbl_amenities.Text = "4 Guest - Mineral Water - Wifi - Air Conditioner";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(576, 160);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(103, 17);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Rp 50.000 / Jam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 1);
            this.panel1.TabIndex = 5;
            // 
            // RoomCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_amenities);
            this.Controls.Add(this.lbl_roomName);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.pb_roomImage);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RoomCardControl";
            this.Size = new System.Drawing.Size(700, 200);
            this.Load += new System.EventHandler(this.RoomCardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_roomImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_roomImage;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_roomName;
        private System.Windows.Forms.Label lbl_amenities;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel panel1;
    }
}
