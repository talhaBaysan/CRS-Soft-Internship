﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Flight_Click(object sender, EventArgs e)
        {
            Flights flight = new Flights();
            flight.Show();
            this.Hide();
        }

        private void Passenger_Click(object sender, EventArgs e)
        {
            Passengers pass = new Passengers();
            pass.Show();
            this.Hide();
        }

        private void Ticket_Click(object sender, EventArgs e)
        {
            Tickets tick = new Tickets();
            tick.Show();
            this.Hide();
        }

        private void Cancellation_Click(object sender, EventArgs e)
        {
            Cancellations cancel = new Cancellations();
            cancel.Show();
            this.Hide();
        }

        private void HExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
