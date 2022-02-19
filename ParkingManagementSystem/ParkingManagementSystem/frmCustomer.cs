using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkingManagementSystem
{
    public partial class frmCustomer : Form
    {
       
        public frmCustomer()
        {
            InitializeComponent();
            label_Result.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                label_Result.Visible = true;
                label_Result.Text = "All Fields Required";
                label_Result.ForeColor = Color.Red;
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "INSERT INTO Customer (CustomerName, CNIC, Age) values ('" + textBox1.Text + "','" + textBox3.Text + "'," + textBox2.Text + ")";
                DBHandler.executeInsertQuery(sqlCommand);
                label_Result.Text = "Record Entered Successfully";
                label_Result.Visible = true;
                label_Result.ForeColor = Color.DarkGreen;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = default;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.BackColor = default;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.BackColor = default;
        }
    }
}
