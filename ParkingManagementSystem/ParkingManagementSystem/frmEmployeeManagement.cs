using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class frmEmployeeManagement : Form
    {
        string adminID;
        int count = 0;
        DataTable registered_employees;
        public frmEmployeeManagement(string adminID)
        {
            InitializeComponent();
            this.adminID = adminID;
            registered_employees= DBHandler.executeSelectQuery("select ManagerID,UserName from ParkingManager");
            dataGridView1.DataSource = registered_employees;
            delete_emp.Visible = false;
            delete_emplbl.Visible = false;
            label7.Visible = false;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_username.Text == "" || textBox_pass.Text == "" || comboBox_Role.Text == "")
            {
                MessageBox.Show("Please Enter the fields Before Clicking on Register");
                textBox_name.BackColor = Color.Red;
                textBox_username.BackColor = Color.Red;
                textBox_pass.BackColor = Color.Red;
            }
            else
            {
                if (comboBox_Role.SelectedItem.ToString() == "ParkingManager")
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "INSERT INTO ParkingManager (UserName, Password, AdminID,ManagerName) values (@user,@pass,@admin,@name)";
                    sqlCommand.Parameters.AddWithValue("@user", textBox_username.Text);
                    sqlCommand.Parameters.AddWithValue("@pass", textBox_pass.Text);
                    sqlCommand.Parameters.AddWithValue("@admin", adminID);
                    sqlCommand.Parameters.AddWithValue("@name", textBox_name.Text);
                    DBHandler.executeInsertQuery(sqlCommand);
                    dataGridView1.Refresh();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "INSERT INTO Admin (UserName, Password, AdminName) values (@user,@pass,@name)";
                    sqlCommand.Parameters.AddWithValue("@user", textBox_username.Text);
                    sqlCommand.Parameters.AddWithValue("@pass", textBox_pass.Text);
                    sqlCommand.Parameters.AddWithValue("@name", textBox_name.Text);
                    DBHandler.executeInsertQuery(sqlCommand);
                }
                label7.Visible = true;
                label7.ForeColor = Color.DarkGreen;
                label7.Text = "User Added";
            }
        }
        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (delete_emp.Text == "")
            {
                MessageBox.Show("Please Enter ManagerID");
            }
            else
            {
                count++;
                if (count == 1)
                {
                    //MessageBox.Show("Delete Field Enabled. Please Enter the ManagerID in the Field (Enabled Recently)");
                    delete_emp.Visible = true;
                    delete_emplbl.Visible = true;
                    label7.Visible = true;
                    label7.ForeColor = Color.Red;
                    label7.Text = "Please Enter the ManagerID below:";
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Delete ParkingManager where ManagerID= " + delete_emp.Text + "";
                    DBHandler.executeInsertQuery(sqlCommand);
                    label7.Visible = true;
                    label7.ForeColor = Color.DarkGreen;
                    label7.Text = "User Deleted";

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_name_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_name.BackColor = default;
        }

        private void textBox_username_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_username.BackColor = default;
        }

        private void textBox_pass_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_pass.BackColor = default;
        }
    }
}
