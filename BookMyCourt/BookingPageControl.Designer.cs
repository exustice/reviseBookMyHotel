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
            this.startDatelbl = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.endTimelbl = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.roomTypelbl = new System.Windows.Forms.Label();
            this.bedTypelbl = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbBedType = new System.Windows.Forms.ComboBox();
            this.endDatelbl = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.ReservationIDTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stp1NextButton = new System.Windows.Forms.Button();
            this.stp2BackButton = new System.Windows.Forms.Button();
            this.stp1lbl = new System.Windows.Forms.Label();
            this.stp2NextButton = new System.Windows.Forms.Button();
            this.stp3BackButton = new System.Windows.Forms.Button();
            this.stp2lbl = new System.Windows.Forms.Label();
            this.stp3lbl = new System.Windows.Forms.Label();
            this.notelbl = new System.Windows.Forms.Label();
            this.roomPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomPic)).BeginInit();
            this.SuspendLayout();
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.CausesValidation = false;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(334, 147);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(115, 20);
            this.idlbl.TabIndex = 1;
            this.idlbl.Text = "Reservation ID";
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(329, 225);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(125, 20);
            this.contactlbl.TabIndex = 3;
            this.contactlbl.Text = "Contact Number";
            // 
            // hotellbl
            // 
            this.hotellbl.AutoSize = true;
            this.hotellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotellbl.Location = new System.Drawing.Point(334, 127);
            this.hotellbl.Name = "hotellbl";
            this.hotellbl.Size = new System.Drawing.Size(93, 20);
            this.hotellbl.TabIndex = 4;
            this.hotellbl.Text = "Hotel Name";
            // 
            // startTimelbl
            // 
            this.startTimelbl.AutoSize = true;
            this.startTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimelbl.Location = new System.Drawing.Point(257, 300);
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
            this.ContactTextBox.Location = new System.Drawing.Point(308, 207);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(160, 20);
            this.ContactTextBox.TabIndex = 17;
            this.ContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactTextBox_KeyPress);
            // 
            // startDatelbl
            // 
            this.startDatelbl.AutoSize = true;
            this.startDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatelbl.Location = new System.Drawing.Point(337, 184);
            this.startDatelbl.Name = "startDatelbl";
            this.startDatelbl.Size = new System.Drawing.Size(83, 20);
            this.startDatelbl.TabIndex = 22;
            this.startDatelbl.Text = "Start Date";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(217, 274);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(160, 20);
            this.dtpStartTime.TabIndex = 25;
            this.dtpStartTime.Value = new System.DateTime(2023, 6, 22, 9, 8, 0, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // endTimelbl
            // 
            this.endTimelbl.AutoSize = true;
            this.endTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimelbl.Location = new System.Drawing.Point(454, 300);
            this.endTimelbl.Name = "endTimelbl";
            this.endTimelbl.Size = new System.Drawing.Size(72, 20);
            this.endTimelbl.TabIndex = 27;
            this.endTimelbl.Text = "End time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(405, 274);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(172, 20);
            this.dtpEndTime.TabIndex = 28;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(261, 162);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(255, 20);
            this.datePicker.TabIndex = 29;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(261, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(255, 20);
            this.nameTextBox.TabIndex = 31;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(474, 124);
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
            this.roomTypelbl.Location = new System.Drawing.Point(351, 245);
            this.roomTypelbl.Name = "roomTypelbl";
            this.roomTypelbl.Size = new System.Drawing.Size(90, 20);
            this.roomTypelbl.TabIndex = 33;
            this.roomTypelbl.Text = "Room Type";
            // 
            // bedTypelbl
            // 
            this.bedTypelbl.AutoSize = true;
            this.bedTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedTypelbl.Location = new System.Drawing.Point(351, 297);
            this.bedTypelbl.Name = "bedTypelbl";
            this.bedTypelbl.Size = new System.Drawing.Size(76, 20);
            this.bedTypelbl.TabIndex = 35;
            this.bedTypelbl.Text = "Bed Type";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(268, 321);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(87, 20);
            this.lblTotalPrice.TabIndex = 37;
            this.lblTotalPrice.Text = "Total Price:";
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
            this.cmbRoomType.Location = new System.Drawing.Point(308, 221);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(169, 21);
            this.cmbRoomType.TabIndex = 39;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged_1);
            // 
            // cmbBedType
            // 
            this.cmbBedType.FormattingEnabled = true;
            this.cmbBedType.Location = new System.Drawing.Point(308, 273);
            this.cmbBedType.Name = "cmbBedType";
            this.cmbBedType.Size = new System.Drawing.Size(169, 21);
            this.cmbBedType.TabIndex = 40;
            // 
            // endDatelbl
            // 
            this.endDatelbl.AutoSize = true;
            this.endDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatelbl.Location = new System.Drawing.Point(342, 231);
            this.endDatelbl.Name = "endDatelbl";
            this.endDatelbl.Size = new System.Drawing.Size(77, 20);
            this.endDatelbl.TabIndex = 42;
            this.endDatelbl.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(261, 208);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(255, 20);
            this.dtpEndDate.TabIndex = 43;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate1);
            // 
            // ReservationIDTextBox
            // 
            this.ReservationIDTextBox.BackColor = System.Drawing.Color.White;
            this.ReservationIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReservationIDTextBox.Location = new System.Drawing.Point(309, 123);
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
            // stp1NextButton
            // 
            this.stp1NextButton.Location = new System.Drawing.Point(659, 341);
            this.stp1NextButton.Name = "stp1NextButton";
            this.stp1NextButton.Size = new System.Drawing.Size(134, 24);
            this.stp1NextButton.TabIndex = 46;
            this.stp1NextButton.Text = "NEXT";
            this.stp1NextButton.UseVisualStyleBackColor = true;
            this.stp1NextButton.Click += new System.EventHandler(this.stp1NextButton_Click);
            // 
            // stp2BackButton
            // 
            this.stp2BackButton.Location = new System.Drawing.Point(25, 346);
            this.stp2BackButton.Name = "stp2BackButton";
            this.stp2BackButton.Size = new System.Drawing.Size(134, 24);
            this.stp2BackButton.TabIndex = 47;
            this.stp2BackButton.Text = "BACK";
            this.stp2BackButton.UseVisualStyleBackColor = true;
            this.stp2BackButton.Visible = false;
            this.stp2BackButton.Click += new System.EventHandler(this.stp2BackButton_Click);
            // 
            // stp1lbl
            // 
            this.stp1lbl.AutoSize = true;
            this.stp1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp1lbl.Location = new System.Drawing.Point(171, 43);
            this.stp1lbl.Name = "stp1lbl";
            this.stp1lbl.Size = new System.Drawing.Size(432, 31);
            this.stp1lbl.TabIndex = 48;
            this.stp1lbl.Text = "STEP 1 - CHOOSE YOUR HOTEL";
            // 
            // stp2NextButton
            // 
            this.stp2NextButton.Location = new System.Drawing.Point(659, 341);
            this.stp2NextButton.Name = "stp2NextButton";
            this.stp2NextButton.Size = new System.Drawing.Size(134, 24);
            this.stp2NextButton.TabIndex = 49;
            this.stp2NextButton.Text = "NEXT";
            this.stp2NextButton.UseVisualStyleBackColor = true;
            this.stp2NextButton.Visible = false;
            this.stp2NextButton.Click += new System.EventHandler(this.stp2NextButton_Click_1);
            // 
            // stp3BackButton
            // 
            this.stp3BackButton.Location = new System.Drawing.Point(25, 342);
            this.stp3BackButton.Name = "stp3BackButton";
            this.stp3BackButton.Size = new System.Drawing.Size(134, 24);
            this.stp3BackButton.TabIndex = 50;
            this.stp3BackButton.Text = "BACK";
            this.stp3BackButton.UseVisualStyleBackColor = true;
            this.stp3BackButton.Visible = false;
            this.stp3BackButton.Click += new System.EventHandler(this.stp3BackButton_Click);
            // 
            // stp2lbl
            // 
            this.stp2lbl.AutoSize = true;
            this.stp2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp2lbl.Location = new System.Drawing.Point(73, 43);
            this.stp2lbl.Name = "stp2lbl";
            this.stp2lbl.Size = new System.Drawing.Size(631, 31);
            this.stp2lbl.TabIndex = 51;
            this.stp2lbl.Text = "STEP 2 - CHOOSE YOUR ROOM AND BED TYPE";
            // 
            // stp3lbl
            // 
            this.stp3lbl.AutoSize = true;
            this.stp3lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp3lbl.Location = new System.Drawing.Point(73, 48);
            this.stp3lbl.Name = "stp3lbl";
            this.stp3lbl.Size = new System.Drawing.Size(612, 31);
            this.stp3lbl.TabIndex = 52;
            this.stp3lbl.Text = "STEP 3 - FILL OUT YOUR PERSONAL DETAILS";
            // 
            // notelbl
            // 
            this.notelbl.AutoSize = true;
            this.notelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notelbl.ForeColor = System.Drawing.Color.Red;
            this.notelbl.Location = new System.Drawing.Point(239, 325);
            this.notelbl.Name = "notelbl";
            this.notelbl.Size = new System.Drawing.Size(314, 13);
            this.notelbl.TabIndex = 53;
            this.notelbl.Text = "Note: We only accept sharp hourly basis e.g., 1:00PM - 10:00AM";
            // 
            // roomPic
            // 
            this.roomPic.Image = global::BookMyCourt.Properties.Resources.premium;
            this.roomPic.Location = new System.Drawing.Point(235, 82);
            this.roomPic.Name = "roomPic";
            this.roomPic.Size = new System.Drawing.Size(342, 135);
            this.roomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomPic.TabIndex = 54;
            this.roomPic.TabStop = false;
            // 
            // BookingPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.ReservationIDTextBox);
            this.Controls.Add(this.notelbl);
            this.Controls.Add(this.stp3lbl);
            this.Controls.Add(this.stp2lbl);
            this.Controls.Add(this.stp3BackButton);
            this.Controls.Add(this.stp2NextButton);
            this.Controls.Add(this.stp1lbl);
            this.Controls.Add(this.stp2BackButton);
            this.Controls.Add(this.stp1NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.endDatelbl);
            this.Controls.Add(this.cmbBedType);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.bedTypelbl);
            this.Controls.Add(this.roomTypelbl);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.endTimelbl);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.startDatelbl);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.startTimelbl);
            this.Controls.Add(this.hotellbl);
            this.Controls.Add(this.roomPic);
            this.Name = "BookingPageControl";
            this.Size = new System.Drawing.Size(817, 397);
            this.Load += new System.EventHandler(this.BookingPageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomPic)).EndInit();
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
        private System.Windows.Forms.Label startDatelbl;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label endTimelbl;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label roomTypelbl;
        private System.Windows.Forms.Label bedTypelbl;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbBedType;
        private System.Windows.Forms.Label endDatelbl;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label ReservationIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stp1NextButton;
        private System.Windows.Forms.Button stp2BackButton;
        private System.Windows.Forms.Label stp1lbl;
        private System.Windows.Forms.Button stp2NextButton;
        private System.Windows.Forms.Button stp3BackButton;
        private System.Windows.Forms.Label stp2lbl;
        private System.Windows.Forms.Label stp3lbl;
        private System.Windows.Forms.Label notelbl;
        private System.Windows.Forms.PictureBox roomPic;
    }
}
