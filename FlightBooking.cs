﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingProject
{
    public partial class FlightBooking : Form
    {
        public static string fullName { get; set; }
        public static string departure { get; set; }
        public static string destination { get; set; }
        public static string tripDates { get; set; }
        public static string passportNo { get; set; }
        public static DateTime passExpiry { get; set; }
        public static string estimateWeight { get; set; }

        public FlightBooking()
        {
            InitializeComponent();
        }

        private void makingVisible()
        {
            lblDocNo.Visible = true;
            lblDocIssueDate.Visible = true;
            lblDocExpiryDate.Visible = true;

            txtDocNo.Visible = true;
            dtpDocIssueDate.Visible = true;
            dtpDocExpiryDate.Visible = true;
        }

        private void rbPassport_CheckedChanged(object sender, EventArgs e)
        {
            makingVisible();

            lblDocNo.Text = "Passport No.";
            lblDocIssueDate.Text = "Passport Issue Date";
            lblDocExpiryDate.Text = "Passport Expiry Date";
        }

        private void rbIdentify_CheckedChanged(object sender, EventArgs e)
        {
            makingVisible();

            lblDocNo.Text = "ID Card No.";
            lblDocIssueDate.Text = "ID Card Issue Date";
            lblDocExpiryDate.Text = "ID Card Expiry Date";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "" | txtDestination.Text == "" || txtFirstName.Text == "" ||
                txtLastName.Text == "" || txtDocNo.Text == "")
            {
                MessageBox.Show("Enter Appropriate Values", "Missing Values");
            }
            else
            {
                fullName = txtFirstName.Text + " " + txtLastName.Text;
                departure = txtDeparture.Text;
                destination = txtDestination.Text;
                passportNo = txtDocNo.Text;

                string startDate = Convert.ToString(monthCalendar1.SelectionStart);
                string endDate = Convert.ToString(monthCalendar1.SelectionEnd);
                tripDates = startDate + " To " + endDate;

                passExpiry = dtpDocExpiryDate.Value;
                estimateWeight = numericUpDownBaggage.Value.ToString();

                BookingSummary bForm = new BookingSummary();
                bForm.Show();
                Hide();
            }
        }

        private void FlightBooking_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}