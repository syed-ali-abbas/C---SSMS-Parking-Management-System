using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class frmCheckout : Form
    {
        string slotID;
        public frmCheckout(string slotID, string slotname, string bookingID)
        {
            InitializeComponent();            
            label_SlotName.Text = slotname;
            DataRow Booking = DBHandler.executeSelectQuery("SELECT * FROM Bookings WHERE BookingID = " + bookingID).Rows[0];
            label_numberplate.Text = Booking["VehicleNumberPlate"].ToString();
            label_empid.Text = Booking["ManagerID"].ToString();
            label_charges.Text = calculatefees(Booking["VehicleTypeID"].ToString());
            this.slotID = slotID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Slots SET isBooked = 0, BookingID = 0 WHERE SlotID = @slotid";
            sqlCommand.Parameters.AddWithValue("@slotid", slotID);
            DBHandler.executeInsertQuery(sqlCommand);
            sqlCommand.CommandText = "UPDATE Bookings SET CheckOutTime= '"+ DateTime.Parse(DateTime.Now.ToString("U")) + "'  WHERE SlotID = @slotid";
            DBHandler.executeInsertQuery(sqlCommand);
            label_Res.Text = "Thank you for choosing us";
        }
        private string calculatefees(string vehicleTypeID)
        {
            DataTable dt_vehicleTypes = DBHandler.executeSelectQuery("SELECT * FROM VehicleType");
            DataRow dr = dt_vehicleTypes.Select("VehicleTypeID = " + vehicleTypeID)[0];
            return dr["Fees"].ToString() + " Pkr";            
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
