using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class frmCheckin : Form
    {
        private int slotID = 0;
        private string userID;
        public frmCheckin()
        {
            InitializeComponent();
        }
        public frmCheckin(string slotname,int slotID, string userID)
        {
            InitializeComponent();
            label_SlotName.Text = slotname;
            this.slotID = slotID;
            this.userID = userID;
            loadComboBox();
            label7.Visible = false;
        }

        private void button_checkIn_Click(object sender, EventArgs e)
        {
            if (textBox_Plate.Text == "" || textBox2.Text == "" || comboBox_Vehicle.Text=="")
            {
                textBox_Plate.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                label7.Visible = true;
                label7.Text = "All Fields Required";
                label7.ForeColor = Color.Red;
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "INSERT INTO Bookings (SlotID, ManagerID, VehicleNumberPlate,VehicleTypeID, CheckInTime) values (@slot,@manager,@numberplate,@vehtype,@checkintime)";
                sqlCommand.Parameters.AddWithValue("@slot", slotID);
                sqlCommand.Parameters.AddWithValue("@manager", userID);
                sqlCommand.Parameters.AddWithValue("@vehtype", comboBox_Vehicle.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@numberplate", textBox_Plate.Text);
                sqlCommand.Parameters.AddWithValue("@checkintime", DateTime.Parse(DateTime.Now.ToString("U")));
                DBHandler.executeInsertQuery(sqlCommand);
                DataRow dr = DBHandler.executeSelectQuery("SELECT BookingID from Bookings WHERE SlotID = '" + slotID + "' and VehicleNumberPlate='" + textBox_Plate.Text + "' ORDER BY CheckInTime DESC").Rows[0];
                sqlCommand.CommandText = "UPDATE Slots SET isBooked = 1, BookingID = @bookingID WHERE SlotID = @slotid";
                sqlCommand.Parameters.AddWithValue("@slotid", slotID);
                sqlCommand.Parameters.AddWithValue("@BookingID", dr["BookingID"]);
                DBHandler.executeInsertQuery(sqlCommand);
                this.Close();
                label7.Visible = true;
                label7.Text = "CheckIn Successful";
                label7.ForeColor = Color.DarkGreen;
            }
        }
        private void button_addCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.Show();
        }
        private void loadComboBox()
        {
            DataTable dt_vehtypes = DBHandler.executeSelectQuery("SELECT VehicleTypeID, TypeName FROM VehicleType");
            comboBox_Vehicle.DataSource = dt_vehtypes;
            comboBox_Vehicle.ValueMember = dt_vehtypes.Columns[0].ColumnName;
            comboBox_Vehicle.DisplayMember = dt_vehtypes.Columns[1].ColumnName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Plate_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Plate.BackColor = default;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.BackColor = default;
        }
    }
}
