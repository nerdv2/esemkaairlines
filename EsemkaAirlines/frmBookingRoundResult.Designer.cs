namespace EsemkaAirlines
{
    partial class frmBookingRoundResult
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
            this.labelSelected = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataResult = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataReturnResult = new System.Windows.Forms.DataGridView();
            this.labelReturnSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReturnResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(450, 253);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(81, 13);
            this.labelSelected.TabIndex = 18;
            this.labelSelected.Text = "Selected Data :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 468);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 34);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(542, 468);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(104, 34);
            this.btnProcess.TabIndex = 16;
            this.btnProcess.Text = "Select Flight";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Flight Data";
            // 
            // dataResult
            // 
            this.dataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResult.Location = new System.Drawing.Point(19, 95);
            this.dataResult.MultiSelect = false;
            this.dataResult.Name = "dataResult";
            this.dataResult.ReadOnly = true;
            this.dataResult.Size = new System.Drawing.Size(627, 150);
            this.dataResult.TabIndex = 14;
            this.dataResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResult_CellClick);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(534, 33);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(10, 13);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "-";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Booking ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "New Flight Booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Flight Return Data";
            // 
            // dataReturnResult
            // 
            this.dataReturnResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReturnResult.Location = new System.Drawing.Point(19, 294);
            this.dataReturnResult.MultiSelect = false;
            this.dataReturnResult.Name = "dataReturnResult";
            this.dataReturnResult.ReadOnly = true;
            this.dataReturnResult.Size = new System.Drawing.Size(627, 150);
            this.dataReturnResult.TabIndex = 19;
            this.dataReturnResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReturnResult_CellClick);
            // 
            // labelReturnSelected
            // 
            this.labelReturnSelected.AutoSize = true;
            this.labelReturnSelected.Location = new System.Drawing.Point(450, 278);
            this.labelReturnSelected.Name = "labelReturnSelected";
            this.labelReturnSelected.Size = new System.Drawing.Size(81, 13);
            this.labelReturnSelected.TabIndex = 21;
            this.labelReturnSelected.Text = "Selected Data :";
            // 
            // frmBookingRoundResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 514);
            this.Controls.Add(this.labelReturnSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataReturnResult);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataResult);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBookingRoundResult";
            this.Text = "frmBookingRoundResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReturnResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataResult;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataReturnResult;
        private System.Windows.Forms.Label labelReturnSelected;
    }
}