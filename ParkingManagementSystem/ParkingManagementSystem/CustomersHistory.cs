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
    public partial class CustomersHistory : Form
    {
        DataTable customersDataTable;
        public CustomersHistory()
        {
            InitializeComponent();
            customersDataTable = DBHandler.executeSelectQuery("Select * from Customer");
            dataGridView1.DataSource = customersDataTable;
        }

        private void CustomersHistory_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
