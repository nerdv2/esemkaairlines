﻿namespace EsemkaAirlines
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnAirplane = new System.Windows.Forms.Button();
            this.btnAirport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBooking = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnFlightData = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "esemkaAirlines";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFooter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 274);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelFooter
            // 
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(156, 17);
            this.labelFooter.Text = "Welcome to esemkaAirlines!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.schedulingToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.boardingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airplaneDataToolStripMenuItem,
            this.airportDataToolStripMenuItem,
            this.scheduleDataToolStripMenuItem});
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            // 
            // airplaneDataToolStripMenuItem
            // 
            this.airplaneDataToolStripMenuItem.Name = "airplaneDataToolStripMenuItem";
            this.airplaneDataToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.airplaneDataToolStripMenuItem.Text = "Airplane Data";
            this.airplaneDataToolStripMenuItem.Click += new System.EventHandler(this.airplaneDataToolStripMenuItem_Click);
            // 
            // airportDataToolStripMenuItem
            // 
            this.airportDataToolStripMenuItem.Name = "airportDataToolStripMenuItem";
            this.airportDataToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.airportDataToolStripMenuItem.Text = "Airport Data";
            this.airportDataToolStripMenuItem.Click += new System.EventHandler(this.airportDataToolStripMenuItem_Click);
            // 
            // scheduleDataToolStripMenuItem
            // 
            this.scheduleDataToolStripMenuItem.Name = "scheduleDataToolStripMenuItem";
            this.scheduleDataToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.scheduleDataToolStripMenuItem.Text = "Schedule Data";
            this.scheduleDataToolStripMenuItem.Click += new System.EventHandler(this.scheduleDataToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingDataToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookingDataToolStripMenuItem
            // 
            this.bookingDataToolStripMenuItem.Name = "bookingDataToolStripMenuItem";
            this.bookingDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookingDataToolStripMenuItem.Text = "Booking Data";
            this.bookingDataToolStripMenuItem.Click += new System.EventHandler(this.bookingDataToolStripMenuItem_Click);
            // 
            // boardingToolStripMenuItem
            // 
            this.boardingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightDataToolStripMenuItem,
            this.checkinToolStripMenuItem});
            this.boardingToolStripMenuItem.Name = "boardingToolStripMenuItem";
            this.boardingToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.boardingToolStripMenuItem.Text = "Boarding";
            // 
            // flightDataToolStripMenuItem
            // 
            this.flightDataToolStripMenuItem.Name = "flightDataToolStripMenuItem";
            this.flightDataToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.flightDataToolStripMenuItem.Text = "Flight Data";
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.checkinToolStripMenuItem.Text = "Check-in";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(62, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 126);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSchedule);
            this.tabPage1.Controls.Add(this.btnAirplane);
            this.tabPage1.Controls.Add(this.btnAirport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scheduling";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(374, 28);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Schedule Data";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAirplane
            // 
            this.btnAirplane.Location = new System.Drawing.Point(189, 28);
            this.btnAirplane.Name = "btnAirplane";
            this.btnAirplane.Size = new System.Drawing.Size(146, 42);
            this.btnAirplane.TabIndex = 1;
            this.btnAirplane.Text = "Airplane Data";
            this.btnAirplane.UseVisualStyleBackColor = true;
            this.btnAirplane.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAirport
            // 
            this.btnAirport.Location = new System.Drawing.Point(6, 28);
            this.btnAirport.Name = "btnAirport";
            this.btnAirport.Size = new System.Drawing.Size(146, 42);
            this.btnAirport.TabIndex = 0;
            this.btnAirport.Text = "Airport Data";
            this.btnAirport.UseVisualStyleBackColor = true;
            this.btnAirport.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBooking);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Booking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(190, 29);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(146, 42);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Booking Data";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCheckIn);
            this.tabPage3.Controls.Add(this.btnFlightData);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(526, 100);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boarding";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(290, 29);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(146, 42);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnFlightData
            // 
            this.btnFlightData.Location = new System.Drawing.Point(85, 29);
            this.btnFlightData.Name = "btnFlightData";
            this.btnFlightData.Size = new System.Drawing.Size(146, 42);
            this.btnFlightData.TabIndex = 1;
            this.btnFlightData.Text = "Flight Data";
            this.btnFlightData.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 296);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "esemkaAirlines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelFooter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airplaneDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boardingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnAirplane;
        private System.Windows.Forms.Button btnAirport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnFlightData;
    }
}

