using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class carParkingHistory : Form
    {
        DataTable carParkingHistry;
        public carParkingHistory()
        {
            InitializeComponent();
            carParkingHistry= DBHandler.executeSelectQuery("Select * from Bookings");
            dataGridView1.DataSource = carParkingHistry;
           
        }

        private void carParkingHistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
