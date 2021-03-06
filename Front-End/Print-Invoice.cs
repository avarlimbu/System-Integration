﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Prints invoice for the user showing the booked items

namespace Front_End
{
    public partial class Print_Invoice : Form
    {

       
        public Print_Invoice(string date,string firstname, string surname,string address,string phonenumber,string destination,string flightprice,
                             string carDetails,string carhirePrice,string hotellocation,string hotelprice,string total)
        {
            InitializeComponent();

            dateLbl.Text = date;
            fnameLbl.Text = firstname;
            snameLbl.Text = surname;
            addrLbl.Text = address;
            phonenumLbl.Text = phonenumber;
            destiLbl.Text = destination;
            flipriceLbl.Text = flightprice;
            cardetailLbl.Text = carDetails;
            carpriceLbl.Text = carhirePrice;
            locatLbl.Text = hotellocation;
            htlpriLbl.Text = hotelprice;
            totalLbl.Text = total;
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to go back to the homepage without printing the invoice?";
            const string caption = "CANCEL";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                main m = new main();
                m.ShowDialog();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Print_Invoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string text = "Confirmation Complete!";
            const string caption = "CANCEL";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                main m = new main();
                m.ShowDialog();
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("Print confirmed");
                this.Close();
            }
        }
    }
}
