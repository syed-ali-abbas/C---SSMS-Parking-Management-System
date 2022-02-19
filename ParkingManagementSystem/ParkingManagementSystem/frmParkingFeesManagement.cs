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
    public partial class frmParkingFeesManagement : Form
    {
        DataTable dt_vehicleTypes;
        public frmParkingFeesManagement()
        {
            InitializeComponent();
            dt_vehicleTypes = DBHandler.executeSelectQuery("SELECT TypeName,Fees FROM VehicleType");
            dataGridView1.DataSource = dt_vehicleTypes;
            comboBox1.DataSource = dt_vehicleTypes;
            comboBox1.ValueMember = dt_vehicleTypes.Columns[0].ColumnName;
            comboBox1.DisplayMember = dt_vehicleTypes.Columns[0].ColumnName;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            
            sqlCommand.CommandText = "UPDATE VehicleType SET Fees = @Fees WHERE TypeName = @type";
            int fees;
            try
            {
                fees = int.Parse(textBox_fees.Text);
            }
            catch (Exception)
            {
                fees = 0;
                throw;
            }
            if (fees > 0)
            {
                sqlCommand.Parameters.AddWithValue("@Fees", textBox_fees.Text);
                sqlCommand.Parameters.AddWithValue("@type", comboBox1.SelectedValue.ToString());
                DBHandler.executeInsertQuery(sqlCommand);
                label_res.Text = "Fees Updated";
                label_res.ForeColor = Color.Green;
            }
            else
            {
                label_res.ForeColor = Color.Red;
                label_res.Text = "Invalid Fees";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
