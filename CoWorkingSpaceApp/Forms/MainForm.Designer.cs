namespace CoWorkingSpaceApp.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Booking = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_MasterWorkspace = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgv_dashboard = new System.Windows.Forms.DataGridView();
            this.space_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lb_totalroom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lb_totaluser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dashboard)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconPictureBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 721);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbWelcome);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.iconPictureBox7);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 561);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 160);
            this.panel7.TabIndex = 31;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(75, 50);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(60, 20);
            this.lbWelcome.TabIndex = 30;
            this.lbWelcome.Text = "Name1";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Halo, Selamat Datang\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox7.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 40;
            this.iconPictureBox7.Location = new System.Drawing.Point(24, 28);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox7.TabIndex = 24;
            this.iconPictureBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.iconPictureBox6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(0, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 84);
            this.panel6.TabIndex = 28;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 40;
            this.iconPictureBox6.Location = new System.Drawing.Point(24, 20);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox6.TabIndex = 23;
            this.iconPictureBox6.TabStop = false;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(9, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 55);
            this.button5.TabIndex = 22;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 21;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox4.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.iconPictureBox4.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 50;
            this.iconPictureBox4.Location = new System.Drawing.Point(21, 21);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox4.TabIndex = 20;
            this.iconPictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Co-Working App";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 367);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.btn_Dashboard);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 84);
            this.panel2.TabIndex = 28;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(24, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.TabIndex = 23;
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Dashboard.Location = new System.Drawing.Point(9, 12);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(231, 55);
            this.btn_Dashboard.TabIndex = 22;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.btn_Booking);
            this.panel3.Location = new System.Drawing.Point(3, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 84);
            this.panel3.TabIndex = 29;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 40;
            this.iconPictureBox2.Location = new System.Drawing.Point(24, 20);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox2.TabIndex = 23;
            this.iconPictureBox2.TabStop = false;
            // 
            // btn_Booking
            // 
            this.btn_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Booking.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Booking.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Booking.Location = new System.Drawing.Point(9, 12);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(231, 55);
            this.btn_Booking.TabIndex = 22;
            this.btn_Booking.Text = "Booking Form";
            this.btn_Booking.UseVisualStyleBackColor = true;
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.btn_MasterWorkspace);
            this.panel4.Location = new System.Drawing.Point(3, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 84);
            this.panel4.TabIndex = 30;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 40;
            this.iconPictureBox3.Location = new System.Drawing.Point(24, 20);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox3.TabIndex = 23;
            this.iconPictureBox3.TabStop = false;
            // 
            // btn_MasterWorkspace
            // 
            this.btn_MasterWorkspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MasterWorkspace.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MasterWorkspace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_MasterWorkspace.Location = new System.Drawing.Point(9, 12);
            this.btn_MasterWorkspace.Name = "btn_MasterWorkspace";
            this.btn_MasterWorkspace.Size = new System.Drawing.Size(231, 55);
            this.btn_MasterWorkspace.TabIndex = 22;
            this.btn_MasterWorkspace.Text = "     Room Management";
            this.btn_MasterWorkspace.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.iconPictureBox5);
            this.panel5.Controls.Add(this.btn_Report);
            this.panel5.Location = new System.Drawing.Point(3, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 84);
            this.panel5.TabIndex = 31;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 40;
            this.iconPictureBox5.Location = new System.Drawing.Point(24, 20);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox5.TabIndex = 23;
            this.iconPictureBox5.TabStop = false;
            // 
            // btn_Report
            // 
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Report.Location = new System.Drawing.Point(9, 12);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(231, 55);
            this.btn_Report.TabIndex = 22;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(257, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1091, 53);
            this.panel8.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2026",
            "2025",
            "2024"});
            this.comboBox1.Location = new System.Drawing.Point(950, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgv_dashboard);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.chart1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(257, 53);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1091, 668);
            this.panel9.TabIndex = 4;
            // 
            // dgv_dashboard
            // 
            this.dgv_dashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dashboard.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_dashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.space_id,
            this.name,
            this.type,
            this.price,
            this.capacity});
            this.dgv_dashboard.EnableHeadersVisualStyles = false;
            this.dgv_dashboard.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_dashboard.Location = new System.Drawing.Point(55, 387);
            this.dgv_dashboard.Name = "dgv_dashboard";
            this.dgv_dashboard.RowHeadersVisible = false;
            this.dgv_dashboard.RowHeadersWidth = 51;
            this.dgv_dashboard.RowTemplate.Height = 24;
            this.dgv_dashboard.Size = new System.Drawing.Size(682, 237);
            this.dgv_dashboard.TabIndex = 3;
            this.dgv_dashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_booking_CellContentClick);
            // 
            // space_id
            // 
            this.space_id.DataPropertyName = "space_id";
            this.space_id.HeaderText = "space_id";
            this.space_id.MinimumWidth = 6;
            this.space_id.Name = "space_id";
            this.space_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nama Ruangan";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Tipe";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // price
            // 
            this.price.DataPropertyName = "amount";
            this.price.HeaderText = "Harga";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Kapasitas";
            this.capacity.MinimumWidth = 6;
            this.capacity.Name = "capacity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Transaksi";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel11.Controls.Add(this.lb_totalroom);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(863, 146);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(202, 82);
            this.panel11.TabIndex = 2;
            // 
            // lb_totalroom
            // 
            this.lb_totalroom.AutoSize = true;
            this.lb_totalroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_totalroom.Location = new System.Drawing.Point(13, 39);
            this.lb_totalroom.Name = "lb_totalroom";
            this.lb_totalroom.Size = new System.Drawing.Size(24, 28);
            this.lb_totalroom.TabIndex = 2;
            this.lb_totalroom.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Room";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel10.Controls.Add(this.lb_totaluser);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(863, 44);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(202, 82);
            this.panel10.TabIndex = 1;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // lb_totaluser
            // 
            this.lb_totaluser.AutoSize = true;
            this.lb_totaluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totaluser.ForeColor = System.Drawing.Color.Blue;
            this.lb_totaluser.Location = new System.Drawing.Point(13, 39);
            this.lb_totaluser.Name = "lb_totaluser";
            this.lb_totaluser.Size = new System.Drawing.Size(24, 25);
            this.lb_totaluser.TabIndex = 1;
            this.lb_totaluser.Text = "1";
            this.lb_totaluser.Click += new System.EventHandler(this.lb_totaluser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data User";
            // 
            // chart1
            // 
            chartArea5.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(30, 44);
            this.chart1.Name = "chart1";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.MediumPurple;
            series13.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.LabelForeColor = System.Drawing.Color.Gray;
            series13.Legend = "Legend1";
            series13.Name = "Booking";
            series14.BorderColor = System.Drawing.Color.DeepSkyBlue;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.DeepPink;
            series14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            series14.LabelForeColor = System.Drawing.Color.Gray;
            series14.Legend = "Legend1";
            series14.Name = "Revenue";
            series14.YValuesPerPoint = 4;
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.DodgerBlue;
            series15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            series15.LabelForeColor = System.Drawing.Color.Gray;
            series15.Legend = "Legend1";
            series15.Name = "Customer";
            series15.YValuesPerPoint = 3;
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(707, 269);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.BorderWidth = 2;
            title5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            title5.Text = "Statistics";
            this.chart1.Titles.Add(title5);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dashboard)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Button btn_Booking;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Button btn_MasterWorkspace;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lb_totalroom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_totaluser;
        private System.Windows.Forms.DataGridView dgv_dashboard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn space_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
    }
}