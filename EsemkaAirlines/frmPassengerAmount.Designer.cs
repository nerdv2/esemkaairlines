namespace EsemkaAirlines
{
    partial class frmPassengerAmount
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelDest = new System.Windows.Forms.Label();
            this.labelDepart = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFlightID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight Booking Confirmation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Booking ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origin Flight :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destination Flight :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departure Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Expected Arrival :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Passenger Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(147, 263);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(56, 20);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(342, 261);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(119, 23);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Process Booking";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(193, 68);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(10, 13);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "-";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelID.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(193, 127);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(10, 13);
            this.labelOrigin.TabIndex = 12;
            this.labelOrigin.Text = "-";
            this.labelOrigin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(193, 158);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(10, 13);
            this.labelDest.TabIndex = 13;
            this.labelDest.Text = "-";
            this.labelDest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.Location = new System.Drawing.Point(193, 189);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(10, 13);
            this.labelDepart.TabIndex = 14;
            this.labelDepart.Text = "-";
            this.labelDepart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(193, 217);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(10, 13);
            this.labelArrival.TabIndex = 15;
            this.labelArrival.Text = "-";
            this.labelArrival.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Flight ID :";
            // 
            // labelFlightID
            // 
            this.labelFlightID.AutoSize = true;
            this.labelFlightID.Location = new System.Drawing.Point(193, 96);
            this.labelFlightID.Name = "labelFlightID";
            this.labelFlightID.Size = new System.Drawing.Size(10, 13);
            this.labelFlightID.TabIndex = 17;
            this.labelFlightID.Text = "-";
            this.labelFlightID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmPassengerAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 296);
            this.Controls.Add(this.labelFlightID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelArrival);
            this.Controls.Add(this.labelDepart);
            this.Controls.Add(this.labelDest);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPassengerAmount";
            this.Text = "frmPassengerAmount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFlightID;
    }
}