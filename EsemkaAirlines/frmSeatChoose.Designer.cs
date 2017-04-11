namespace EsemkaAirlines
{
    partial class frmSeatChoose
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPassenger = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSeatRow = new System.Windows.Forms.ComboBox();
            this.cmbSeatNo = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.btnSeatPreview = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFlightID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flight Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Booking ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Flight ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passenger";
            // 
            // cmbPassenger
            // 
            this.cmbPassenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassenger.FormattingEnabled = true;
            this.cmbPassenger.Location = new System.Drawing.Point(128, 86);
            this.cmbPassenger.Name = "cmbPassenger";
            this.cmbPassenger.Size = new System.Drawing.Size(233, 21);
            this.cmbPassenger.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seat Number";
            // 
            // cmbSeatRow
            // 
            this.cmbSeatRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeatRow.FormattingEnabled = true;
            this.cmbSeatRow.Location = new System.Drawing.Point(128, 124);
            this.cmbSeatRow.Name = "cmbSeatRow";
            this.cmbSeatRow.Size = new System.Drawing.Size(110, 21);
            this.cmbSeatRow.TabIndex = 9;
            // 
            // cmbSeatNo
            // 
            this.cmbSeatNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeatNo.FormattingEnabled = true;
            this.cmbSeatNo.Location = new System.Drawing.Point(251, 124);
            this.cmbSeatNo.Name = "cmbSeatNo";
            this.cmbSeatNo.Size = new System.Drawing.Size(110, 21);
            this.cmbSeatNo.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(379, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.Location = new System.Drawing.Point(469, 84);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(133, 23);
            this.btnPassenger.TabIndex = 12;
            this.btnPassenger.Text = "New Passenger";
            this.btnPassenger.UseVisualStyleBackColor = true;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // btnSeatPreview
            // 
            this.btnSeatPreview.Location = new System.Drawing.Point(379, 122);
            this.btnSeatPreview.Name = "btnSeatPreview";
            this.btnSeatPreview.Size = new System.Drawing.Size(142, 23);
            this.btnSeatPreview.TabIndex = 13;
            this.btnSeatPreview.Text = "Preview Seats";
            this.btnSeatPreview.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(522, 168);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(119, 23);
            this.btnProcess.TabIndex = 14;
            this.btnProcess.Text = "Process Booking";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(527, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(10, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "-";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFlightID
            // 
            this.labelFlightID.AutoSize = true;
            this.labelFlightID.Location = new System.Drawing.Point(527, 36);
            this.labelFlightID.Name = "labelFlightID";
            this.labelFlightID.Size = new System.Drawing.Size(10, 13);
            this.labelFlightID.TabIndex = 16;
            this.labelFlightID.Text = "-";
            this.labelFlightID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmSeatChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 203);
            this.Controls.Add(this.labelFlightID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSeatPreview);
            this.Controls.Add(this.btnPassenger);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbSeatNo);
            this.Controls.Add(this.cmbSeatRow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPassenger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSeatChoose";
            this.Text = "esemkaAirlines - Flight Booking";
            this.Load += new System.EventHandler(this.frmSeatChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPassenger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSeatRow;
        private System.Windows.Forms.ComboBox cmbSeatNo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPassenger;
        private System.Windows.Forms.Button btnSeatPreview;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFlightID;
    }
}