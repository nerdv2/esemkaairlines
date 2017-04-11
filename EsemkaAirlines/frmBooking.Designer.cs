namespace EsemkaAirlines
{
    partial class frmBooking
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.singletripTab = new System.Windows.Forms.TabPage();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.cmbDeparture = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundtripTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbReturnRound = new System.Windows.Forms.DateTimePicker();
            this.cmbDestinationRound = new System.Windows.Forms.ComboBox();
            this.txtCodeRound = new System.Windows.Forms.TextBox();
            this.cmbOriginRound = new System.Windows.Forms.ComboBox();
            this.cmbDepartureRound = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.singletripTab.SuspendLayout();
            this.roundtripTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.singletripTab);
            this.tabControl1.Controls.Add(this.roundtripTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 207);
            this.tabControl1.TabIndex = 0;
            // 
            // singletripTab
            // 
            this.singletripTab.Controls.Add(this.cmbDestination);
            this.singletripTab.Controls.Add(this.txtCode);
            this.singletripTab.Controls.Add(this.cmbOrigin);
            this.singletripTab.Controls.Add(this.cmbDeparture);
            this.singletripTab.Controls.Add(this.label5);
            this.singletripTab.Controls.Add(this.label4);
            this.singletripTab.Controls.Add(this.label3);
            this.singletripTab.Controls.Add(this.label2);
            this.singletripTab.Location = new System.Drawing.Point(4, 22);
            this.singletripTab.Name = "singletripTab";
            this.singletripTab.Padding = new System.Windows.Forms.Padding(3);
            this.singletripTab.Size = new System.Drawing.Size(492, 181);
            this.singletripTab.TabIndex = 0;
            this.singletripTab.Text = "Single Trip";
            this.singletripTab.UseVisualStyleBackColor = true;
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(175, 118);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(292, 21);
            this.cmbDestination.TabIndex = 15;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(109, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(119, 20);
            this.txtCode.TabIndex = 14;
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(175, 84);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(292, 21);
            this.cmbOrigin.TabIndex = 13;
            this.cmbOrigin.SelectedIndexChanged += new System.EventHandler(this.cmbOrigin_SelectedIndexChanged);
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.CustomFormat = "yyyy-MM-dd";
            this.cmbDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbDeparture.Location = new System.Drawing.Point(326, 42);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(141, 20);
            this.cmbDeparture.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Destination :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Origin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Departure Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Booking ID :";
            // 
            // roundtripTab
            // 
            this.roundtripTab.Controls.Add(this.label10);
            this.roundtripTab.Controls.Add(this.cmbReturnRound);
            this.roundtripTab.Controls.Add(this.cmbDestinationRound);
            this.roundtripTab.Controls.Add(this.txtCodeRound);
            this.roundtripTab.Controls.Add(this.cmbOriginRound);
            this.roundtripTab.Controls.Add(this.cmbDepartureRound);
            this.roundtripTab.Controls.Add(this.label6);
            this.roundtripTab.Controls.Add(this.label7);
            this.roundtripTab.Controls.Add(this.label8);
            this.roundtripTab.Controls.Add(this.label9);
            this.roundtripTab.Location = new System.Drawing.Point(4, 22);
            this.roundtripTab.Name = "roundtripTab";
            this.roundtripTab.Padding = new System.Windows.Forms.Padding(3);
            this.roundtripTab.Size = new System.Drawing.Size(492, 181);
            this.roundtripTab.TabIndex = 1;
            this.roundtripTab.Text = "Round Trip";
            this.roundtripTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Return Date :";
            // 
            // cmbReturnRound
            // 
            this.cmbReturnRound.CustomFormat = "yyyy-MM-dd";
            this.cmbReturnRound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbReturnRound.Location = new System.Drawing.Point(326, 68);
            this.cmbReturnRound.Name = "cmbReturnRound";
            this.cmbReturnRound.Size = new System.Drawing.Size(141, 20);
            this.cmbReturnRound.TabIndex = 16;
            // 
            // cmbDestinationRound
            // 
            this.cmbDestinationRound.FormattingEnabled = true;
            this.cmbDestinationRound.Location = new System.Drawing.Point(175, 137);
            this.cmbDestinationRound.Name = "cmbDestinationRound";
            this.cmbDestinationRound.Size = new System.Drawing.Size(292, 21);
            this.cmbDestinationRound.TabIndex = 15;
            // 
            // txtCodeRound
            // 
            this.txtCodeRound.Location = new System.Drawing.Point(109, 42);
            this.txtCodeRound.Name = "txtCodeRound";
            this.txtCodeRound.ReadOnly = true;
            this.txtCodeRound.Size = new System.Drawing.Size(119, 20);
            this.txtCodeRound.TabIndex = 14;
            // 
            // cmbOriginRound
            // 
            this.cmbOriginRound.FormattingEnabled = true;
            this.cmbOriginRound.Location = new System.Drawing.Point(175, 103);
            this.cmbOriginRound.Name = "cmbOriginRound";
            this.cmbOriginRound.Size = new System.Drawing.Size(292, 21);
            this.cmbOriginRound.TabIndex = 13;
            // 
            // cmbDepartureRound
            // 
            this.cmbDepartureRound.CustomFormat = "yyyy-MM-dd";
            this.cmbDepartureRound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbDepartureRound.Location = new System.Drawing.Point(326, 42);
            this.cmbDepartureRound.Name = "cmbDepartureRound";
            this.cmbDepartureRound.Size = new System.Drawing.Size(141, 20);
            this.cmbDepartureRound.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Destination :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Origin :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Departure Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Booking ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Flight Booking";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(401, 283);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(107, 32);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process Request";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 327);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmBooking";
            this.Text = "esemkaAirlines - New Booking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.tabControl1.ResumeLayout(false);
            this.singletripTab.ResumeLayout(false);
            this.singletripTab.PerformLayout();
            this.roundtripTab.ResumeLayout(false);
            this.roundtripTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage singletripTab;
        private System.Windows.Forms.TabPage roundtripTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.DateTimePicker cmbDeparture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker cmbReturnRound;
        private System.Windows.Forms.ComboBox cmbDestinationRound;
        private System.Windows.Forms.TextBox txtCodeRound;
        private System.Windows.Forms.ComboBox cmbOriginRound;
        private System.Windows.Forms.DateTimePicker cmbDepartureRound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}