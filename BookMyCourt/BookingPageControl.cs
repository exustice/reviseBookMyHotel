﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMyCourt
{
    public partial class BookingPageControl : UserControl
    {
        public string reserveID { get; set; }



        public BookingPageControl()
        {
            InitializeComponent();

            datePicker.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;
            nameTextBox.Click += nameTextBox_Click;



            // Set the time interval to 1 hour
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.ShowUpDown = true;

            // Set the initial value for dtpStartTime
            dtpStartTime.Value = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes((DateTime.Now.Minute / 60.0) * 60);

            // Set the time format for dtpEndTime
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.ShowUpDown = true;

            // Set the initial value for dtpEndTime (e.g., 1 hour after the current time)
            dtpEndTime.Value = DateTime.Today.AddHours(DateTime.Now.Hour + 1).AddMinutes((DateTime.Now.Minute / 60.0) * 60);

            dtpStartTime.ValueChanged += dtpStartTime_ValueChanged;
            dtpEndTime.ValueChanged += dtpEndTime_ValueChanged;
            generateButton.Click += generateButton_Click;

            // Add items to cmbRoomType
            cmbRoomType.Items.AddRange(new string[] { "Economy", "Premium", "Deluxe", "Grand" });
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Add items to cmbBedType
            cmbBedType.Items.AddRange(new string[] { "Single", "Double", "Queen", "Deck" });
            cmbBedType.DropDownStyle = ComboBoxStyle.DropDownList;
            // Handle SelectedIndexChanged event of cmbRoomType and cmbBedType
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            cmbBedType.SelectedIndexChanged += cmbBedType_SelectedIndexChanged;

            ShowStep1();
        }


        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime roundedTime = new DateTime(dtpStartTime.Value.Year, dtpStartTime.Value.Month, dtpStartTime.Value.Day, dtpStartTime.Value.Hour, 0, 0);
            dtpStartTime.Value = roundedTime;
            UpdatePriceLabel();
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime roundedTime = new DateTime(dtpEndTime.Value.Year, dtpEndTime.Value.Month, dtpEndTime.Value.Day, dtpEndTime.Value.Hour, 0, 0);
            dtpEndTime.Value = roundedTime;
            UpdatePriceLabel();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string reservationNumber = GenerateRandomString(6);
            ReservationIDTextBox.Text = reservationNumber;
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceLabel();
        }

        private void cmbBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceLabel();
        }

        private void UpdatePriceLabel()
        {
            string roomType = cmbRoomType.SelectedItem?.ToString();
            string bedType = cmbBedType.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(roomType) && !string.IsNullOrEmpty(bedType))
            {
                // Query the database or use any other logic to retrieve the base price based on roomType and bedType
                decimal basePrice = GetPriceByRoomTypeAndBedType(roomType, bedType);

                // Get the selected start time, end time, date, and end date
                DateTime startTime = dtpStartTime.Value;
                DateTime endTime = dtpEndTime.Value;
                DateTime date = datePicker.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                // Calculate the duration in days based on start date and end date
                TimeSpan duration = endDate - date;
                int durationDays = (int)Math.Ceiling(duration.TotalDays);

                // Calculate the duration in hours based on start time and end time
                TimeSpan timeDuration = endTime - startTime;
                int durationHours = (int)Math.Ceiling(timeDuration.TotalHours);

                // Calculate the price adjustment based on the start time and end time
                decimal priceAdjustment = CalculatePriceAdjustment(startTime, endTime);

                // Calculate the final price
                decimal totalPrice = basePrice * durationDays + priceAdjustment;

                // Convert the price to Philippine Peso using the exchange rate
                decimal convertedPrice = ConvertToPhilippinePeso(totalPrice);

                // Format the converted price as Philippine Peso
                string formattedPrice = FormatPriceAsPhilippinePeso(convertedPrice);

                // Update the price label
                lblPrice.Text = formattedPrice;
            }
        }

        private decimal ConvertToPhilippinePeso(decimal priceInDollars)
        {
            // Get the exchange rate from a reliable source (e.g., API)
            decimal exchangeRate = GetExchangeRate(); // Replace this with the actual exchange rate

            // Convert the price from dollars to Philippine Peso
            decimal priceInPhp = priceInDollars * exchangeRate;

            return priceInPhp;
        }

        private string FormatPriceAsPhilippinePeso(decimal priceInPhp)
        {
            // Format the price as Philippine Peso
            string formattedPrice = priceInPhp.ToString("N2");

            // Add the currency symbol "Php"
            formattedPrice = "Php " + formattedPrice;

            return formattedPrice;
        }

        private decimal GetExchangeRate()
        {
            // Retrieve the current exchange rate from an API or any other reliable source
            // Replace this with the actual implementation to get the exchange rate
            // For simplicity, let's assume a fixed exchange rate
            decimal exchangeRate = 50.0m;

            return exchangeRate;
        }



        private decimal GetPriceByRoomTypeAndBedType(string roomType, string bedType)
        {
            // Implement your logic to retrieve the price based on roomType and bedType
            // This can involve querying the database or using any other data source

            // For demonstration purposes, return a static price based on roomType and bedType
            if (roomType == "Economy" && bedType == "Single")
                return 100.00m;
            else if (roomType == "Premium" && bedType == "Double")
                return 150.00m;
            else if (roomType == "Deluxe" && bedType == "Queen")
                return 200.00m;
            else if (roomType == "Grand" && bedType == "Deck")
                return 250.00m;

            return 0.00m; // Default price if no matching combination is found
        }

        private decimal CalculatePrice(string roomType, string bedType, DateTime startTime, DateTime endTime, DateTime endDate)
        {
            // Perform the price calculation based on the selected options
            // You can use a custom algorithm or retrieve the price from a database based on the room type and bed type
            // For simplicity, let's assume a fixed price for each room and bed type
     
            decimal basePrice = GetPriceByRoomTypeAndBedType(roomType, bedType);
            // Calculate the duration in days based on start date and end date
            TimeSpan duration = endDate - startTime.Date;
            int numDays = (int)duration.TotalDays ; // Add 1 to include both the start and end dates

            // Calculate the time-based price adjustment
            decimal priceAdjustment = CalculatePriceAdjustment(startTime, endTime);

            decimal totalPrice =  ConvertToPhilippinePeso (basePrice * numDays + priceAdjustment);

            return totalPrice;
        }
        private decimal CalculatePriceAdjustment(DateTime startTime, DateTime endTime)
        {
            // Implement your logic to calculate the price adjustment based on the start time and end time
            // This can involve any pricing rules or formulas based on specific time intervals

            // For demonstration purposes, return a static price adjustment
            int startHour = startTime.Hour;
            int endHour = endTime.Hour;
            if (startHour >= 0 && startHour < 6 && endHour > 0 && endHour <= 12)
                return 50.00m;
            else if (startHour >= 6 && startHour < 12 && endHour > 6 && endHour <= 18)
                return 100.00m;
            else if (startHour >= 12 && startHour < 18 && endHour > 12 && endHour <= 24)
                return 150.00m;

            return 0.00m; // Default price adjustment if no matching condition is found
        }
        private decimal GetRoomPriceByType(string roomType)
        {
            switch (roomType)
            {
                case "Economy":
                    return 100.00m;
                case "Premium":
                    return 150.00m;
                case "Deluxe":
                    return 200.00m;
                case "Grand":
                    return 250.00m;
                default:
                    return 0.00m;
            }
        }

        private decimal GetBedPriceByType(string bedType)
        {
            switch (bedType)
            {
                case "Single":
                    return 50.00m;
                case "Double":
                    return 80.00m;
                case "Queen":
                    return 100.00m;
                case "Deck":
                    return 120.00m;
                default:
                    return 0.00m;
            }
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb = new StringBuilder(length);
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        public void SetHotelName(string hotelName)
        {
            nameTextBox.Text = hotelName;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-JJULN80\SQLEXPRESS;Initial Catalog=DBbooking;Integrated Security=True";
            string query = "INSERT INTO Bookings (ReservationId, Contact#, Name, StartTime, EndTime, Date, RoomType, BedType, Price, EndDate) VALUES (@ReservationId, @Contact#, @Name, @StartTime, @EndTime, @Date, @RoomType, @BedType, @Price, @EndDate)";

            DateTime startDate = datePicker.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            // Check if the end date is earlier than the start date
            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than the start date. Please select a valid end date.");
                return; // Exit the event handler without proceeding
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@ReservationId", ReservationIDTextBox.Text);
                    command.Parameters.AddWithValue("@Contact#", ContactTextBox.Text);
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@StartTime", dtpStartTime.Value);
                    command.Parameters.AddWithValue("@EndTime", dtpEndTime.Value);
                    command.Parameters.AddWithValue("@Date", datePicker.Value.Date);
                    command.Parameters.AddWithValue("@RoomType", cmbRoomType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@BedType", cmbBedType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Price", CalculatePrice(cmbRoomType.SelectedItem.ToString(), cmbBedType.SelectedItem.ToString(), dtpStartTime.Value, dtpEndTime.Value, dtpEndDate.Value.Date));
                    command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Reservation has been added successfully!");
                            ReservationIDTextBox.Text = string.Empty;
                            ContactTextBox.Text = string.Empty;
                            nameTextBox.Text = string.Empty;
                            cmbRoomType.SelectedIndex = -1;
                            cmbBedType.SelectedIndex = -1;
                            dtpStartTime.Value = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes((DateTime.Now.Minute / 60.0) * 60);
                            dtpEndTime.Value = DateTime.Today.AddHours(DateTime.Now.Hour + 1).AddMinutes((DateTime.Now.Minute / 60.0) * 60);
                            datePicker.Value = DateTime.Today;
                            dtpEndDate.Value = DateTime.Today;
                            lblPrice.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add reservation.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void ContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancel the keypress event if it's not a digit or backspace
                e.Handled = true;
            }

            // Check if the total number of digits exceeds the limit
            if (ContactTextBox.Text.Length >= 12 && e.KeyChar != '\b')
            {
                // Cancel the keypress event if the limit is reached
                e.Handled = true;
            }
        }

        private void dtpEndDate1(object sender, EventArgs e)
        {
            DateTime startDate = datePicker.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            // Check if the end date is earlier than the start date
            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than the start date. Please select a valid end date.");
                dtpEndDate.Value = startDate;
            }
        }

        //hotel name, start end date & time
        private void ShowStep1()
        {
            stp1lbl.Visible = true;
            stp2lbl.Visible = false; 
            stp3lbl.Visible = false;
            notelbl.Visible = true;
            roomPic.Visible = false;

            nameTextBox.Visible = true;
            hotellbl.Visible = true;
            dtpStartTime.Visible = true;
            startTimelbl.Visible = true;
            datePicker.Visible = true;
            startDatelbl.Visible = true;
            dtpEndDate.Visible = true;
            endDatelbl.Visible = true;
            dtpEndTime.Visible = true;
            endTimelbl.Visible = true;
            stp1NextButton.Visible = true;
            stp2NextButton.Visible = false;
            stp2BackButton.Visible = false;
            stp3BackButton.Visible = false;

            cmbRoomType.Visible = false;
            roomTypelbl.Visible = false;
            cmbBedType.Visible = false;
            bedTypelbl.Visible = false;


            ReservationIDTextBox.Visible = false;
            idlbl.Visible = false;
            ContactTextBox.Visible = false;
            contactlbl.Visible = false;
            generateButton.Visible = false;
            totalPricelbl.Visible = false;
            btnSubmit.Visible = false;
        }

        //bed type with picture
        private void ShowStep2()
        {
            stp1lbl.Visible = false;
            stp2lbl.Visible = true;
            stp3lbl.Visible = false;
            notelbl.Visible = false;
            roomPic.Visible = true;

            nameTextBox.Visible = false;
            hotellbl.Visible = false;
            dtpStartTime.Visible = false;
            startTimelbl.Visible = false;
            datePicker.Visible = false;
            startDatelbl.Visible = false;
            dtpEndDate.Visible = false;
            endDatelbl.Visible = false;
            dtpEndTime.Visible = false;
            endTimelbl.Visible = false;
            stp1NextButton.Visible = false;
            stp2NextButton.Visible = true;
            stp2BackButton.Visible = true;
            stp3BackButton.Visible = false;

            cmbRoomType.Visible = true;
            roomTypelbl.Visible = true;
            cmbBedType.Visible = true;
            bedTypelbl.Visible = true;
            cmbRoomType.SelectedItem = "Premium"; // Set the room type to "Premium"

            ReservationIDTextBox.Visible = false;
            idlbl.Visible = false;
            ContactTextBox.Visible = false;
            contactlbl.Visible = false;
            generateButton.Visible = false;
            totalPricelbl.Visible = true;
            btnSubmit.Visible = false;
        }

        //reservation id and other contact details
        private void ShowStep3()
        {
            stp1lbl.Visible = false;
            stp2lbl.Visible = false;
            stp3lbl.Visible = true;
            notelbl.Visible = false;
            roomPic.Visible = false;

            nameTextBox.Visible = false;
            hotellbl.Visible = false;
            dtpStartTime.Visible = false;
            startTimelbl.Visible = false;
            datePicker.Visible = false;
            startDatelbl.Visible = false;
            dtpEndDate.Visible = false;
            endDatelbl.Visible = false;
            dtpEndTime.Visible = false;
            endTimelbl.Visible = false;
            stp1NextButton.Visible = false;
            stp2NextButton.Visible = false;
            stp2BackButton.Visible = false;
            stp3BackButton.Visible = true;

            cmbRoomType.Visible = false;
            roomTypelbl.Visible = false;
            cmbBedType.Visible = false;
            bedTypelbl.Visible = false;


            ReservationIDTextBox.Visible = true;
            idlbl.Visible = true;
            ContactTextBox.Visible = true;
            contactlbl.Visible = true;
            generateButton.Visible = true;
            totalPricelbl.Visible = false;
            btnSubmit.Visible = true;
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("You need to choose a hotel first from the Dashboard.");
                nameTextBox.Focus();
            }
        }

        private void stp3BackButton_Click(object sender, EventArgs e)
        {
            ShowStep2();
        }

    

        private void stp2BackButton_Click(object sender, EventArgs e)
        {
            ShowStep1();
        }

        private void stp1NextButton_Click(object sender, EventArgs e)
        {
            ShowStep2();
        }

        private void stp2NextButton_Click_1(object sender, EventArgs e)
        {
            ShowStep3();
        }

        private void BookingPageControl_Load(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedRoomType = cmbRoomType.SelectedItem?.ToString();

            // Set the corresponding image based on the selected room type
            switch (selectedRoomType)
            {
                case "Economy":
                    roomPic.Image = Properties.Resources.economy; // Assuming the image resource name is "economy"
                    break;
                case "Premium":
                    roomPic.Image = Properties.Resources.premium; // Assuming the image resource name is "premium"
                    break;
                case "Deluxe":
                    roomPic.Image = Properties.Resources.deluxe; // Assuming the image resource name is "deluxe"
                    break;
                case "Grand":
                    roomPic.Image = Properties.Resources.grand; // Assuming the image resource name is "grand"
                    break;
                default:
                    // Handle the default case when no room type is selected
                    // You can set a default image or clear the picture box, depending on your requirement
                    roomPic.Image = null; // Clear the picture box
                    break;
            }
        }

    }
}
