namespace BookMyCourt
{
    partial class BookingPageControl
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
            this.idlbl = new System.Windows.Forms.Label();
            this.contactlbl = new System.Windows.Forms.Label();
            this.hotellbl = new System.Windows.Forms.Label();
            this.startTimelbl = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.startlDatebl = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.endTimelbl = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.roomTypelbl = new System.Windows.Forms.Label();
            this.bedTypelbl = new System.Windows.Forms.Label();
            this.totalPricelbl = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbBedType = new System.Windows.Forms.ComboBox();
            this.endDatelbl = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.ReservationIDTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.CausesValidation = false;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(332, 107);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(115, 20);
            this.idlbl.TabIndex = 1;
            this.idlbl.Text = "Reservation ID";
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(636, 105);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(74, 20);
            this.contactlbl.TabIndex = 3;
            this.contactlbl.Text = "Contact#";
            // 
            // hotellbl
            // 
            this.hotellbl.AutoSize = true;
            this.hotellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotellbl.Location = new System.Drawing.Point(64, 107);
            this.hotellbl.Name = "hotellbl";
            this.hotellbl.Size = new System.Drawing.Size(93, 20);
            this.hotellbl.TabIndex = 4;
            this.hotellbl.Text = "Hotel Name";
            // 
            // startTimelbl
            // 
            this.startTimelbl.AutoSize = true;
            this.startTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimelbl.Location = new System.Drawing.Point(349, 197);
            this.startTimelbl.Name = "startTimelbl";
            this.startTimelbl.Size = new System.Drawing.Size(78, 20);
            this.startTimelbl.TabIndex = 6;
            this.startTimelbl.Text = "Start time";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(333, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 24);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(595, 82);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(160, 20);
            this.ContactTextBox.TabIndex = 17;
            this.ContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactTextBox_KeyPress);
            // 
            // startlDatebl
            // 
            this.startlDatebl.AutoSize = true;
            this.startlDatebl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlDatebl.Location = new System.Drawing.Point(74, 208);
            this.startlDatebl.Name = "startlDatebl";
            this.startlDatebl.Size = new System.Drawing.Size(83, 20);
            this.startlDatebl.TabIndex = 22;
            this.startlDatebl.Text = "Start Date";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(308, 171);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(160, 20);
            this.dtpStartTime.TabIndex = 25;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // endTimelbl
            // 
            this.endTimelbl.AutoSize = true;
            this.endTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimelbl.Location = new System.Drawing.Point(636, 197);
            this.endTimelbl.Name = "endTimelbl";
            this.endTimelbl.Size = new System.Drawing.Size(72, 20);
            this.endTimelbl.TabIndex = 27;
            this.endTimelbl.Text = "End time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(593, 171);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(172, 20);
            this.dtpEndTime.TabIndex = 28;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(32, 182);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(172, 20);
            this.datePicker.TabIndex = 29;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(32, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(255, 20);
            this.nameTextBox.TabIndex = 31;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(473, 82);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(73, 23);
            this.generateButton.TabIndex = 32;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // roomTypelbl
            // 
            this.roomTypelbl.AutoSize = true;
            this.roomTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypelbl.Location = new System.Drawing.Point(347, 285);
            this.roomTypelbl.Name = "roomTypelbl";
            this.roomTypelbl.Size = new System.Drawing.Size(90, 20);
            this.roomTypelbl.TabIndex = 33;
            this.roomTypelbl.Text = "Room Type";
            // 
            // bedTypelbl
            // 
            this.bedTypelbl.AutoSize = true;
            this.bedTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedTypelbl.Location = new System.Drawing.Point(635, 285);
            this.bedTypelbl.Name = "bedTypelbl";
            this.bedTypelbl.Size = new System.Drawing.Size(76, 20);
            this.bedTypelbl.TabIndex = 35;
            this.bedTypelbl.Text = "Bed Type";
            // 
            // totalPricelbl
            // 
            this.totalPricelbl.AutoSize = true;
            this.totalPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPricelbl.Location = new System.Drawing.Point(490, 197);
            this.totalPricelbl.Name = "totalPricelbl";
            this.totalPricelbl.Size = new System.Drawing.Size(87, 20);
            this.totalPricelbl.TabIndex = 37;
            this.totalPricelbl.Text = "Total Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(655, 346);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 20);
            this.lblPrice.TabIndex = 38;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(308, 261);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(169, 21);
            this.cmbRoomType.TabIndex = 39;
            // 
            // cmbBedType
            // 
            this.cmbBedType.FormattingEnabled = true;
            this.cmbBedType.Location = new System.Drawing.Point(596, 261);
            this.cmbBedType.Name = "cmbBedType";
            this.cmbBedType.Size = new System.Drawing.Size(169, 21);
            this.cmbBedType.TabIndex = 40;
            // 
            // endDatelbl
            // 
            this.endDatelbl.AutoSize = true;
            this.endDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatelbl.Location = new System.Drawing.Point(75, 288);
            this.endDatelbl.Name = "endDatelbl";
            this.endDatelbl.Size = new System.Drawing.Size(77, 20);
            this.endDatelbl.TabIndex = 42;
            this.endDatelbl.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(32, 262);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(172, 20);
            this.dtpEndDate.TabIndex = 43;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate1);
            // 
            // ReservationIDTextBox
            // 
            this.ReservationIDTextBox.BackColor = System.Drawing.Color.White;
            this.ReservationIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReservationIDTextBox.Location = new System.Drawing.Point(308, 78);
            this.ReservationIDTextBox.Name = "ReservationIDTextBox";
            this.ReservationIDTextBox.Size = new System.Drawing.Size(159, 24);
            this.ReservationIDTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Booking Page";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(631, 346);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(134, 24);
            this.NextButton.TabIndex = 46;
            this.NextButton.Text = "NEXT";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(32, 342);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 24);
            this.BackButton.TabIndex = 47;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 31);
            this.label2.TabIndex = 48;
            this.label2.Text = "STEP 1 - CHOOSE YOUR HOTEL";
            // 
            // BookingPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReservationIDTextBox);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.endDatelbl);
            this.Controls.Add(this.cmbBedType);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.totalPricelbl);
            this.Controls.Add(this.bedTypelbl);
            this.Controls.Add(this.roomTypelbl);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.endTimelbl);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.startlDatebl);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.startTimelbl);
            this.Controls.Add(this.hotellbl);
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.idlbl);
            this.Name = "BookingPageControl";
            this.Size = new System.Drawing.Size(817, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label hotellbl;
        private System.Windows.Forms.Label startTimelbl;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label startlDatebl;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label endTimelbl;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label roomTypelbl;
        private System.Windows.Forms.Label bedTypelbl;
        private System.Windows.Forms.Label totalPricelbl;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbBedType;
        private System.Windows.Forms.Label endDatelbl;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label ReservationIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
    }
}
