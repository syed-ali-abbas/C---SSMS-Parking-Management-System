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
    public partial class frmParkingManager : Form
    {
        private string userID = "";
        DataTable dt_Slots;
        int vacantSpaces = 0;
        int occupiedSpaces = 0;
        public frmParkingManager()
        {
            InitializeComponent();
                       
        }
        public frmParkingManager(string username, string userRole,string userID)
        {
            InitializeComponent();
            label_UserName.Text = username;
            if (userRole.ToLower() != "admin")
            {
                button_employeeManagement.Hide();
                button_ParkingFees.Hide();
            }
            this.userID = userID;
            refreshMap();
        }
        private void refreshMap()
        {
            string query = "SELECT * FROM Slots";
            dt_Slots = DBHandler.executeSelectQuery(query);
            DataRow[] dataRows = dt_Slots.Select("isBooked = 1");
            if (dataRows != null)
            {
                occupiedSpaces = 0;
                foreach (DataRow dataRow in dataRows)
                {
                    occupiedSpaces++;
                    switch (dataRow["SlotID"].ToString())
                    {
                        case "1":
                            button_slot1.Text = "Parked";
                            break;
                        case "2":
                            button_slot2.Text = "Parked";
                            break;
                        case "3":
                            button_slot3.Text = "Parked";
                            break;
                        case "4":
                            button_slot4.Text = "Parked";
                            break;
                        case "5":
                            button_slot5.Text = "Parked";
                            break;
                        case "6":
                            button_slot6.Text = "Parked";
                            break;
                        case "7":
                            button_slot7.Text = "Parked";
                            break;
                        case "8":
                            button_slot8.Text = "Parked";
                            break;
                        case "9":
                            button_slot9.Text = "Parked";
                            break;
                        case "10":
                            button_slot10.Text = "Parked";
                            break;
                        case "11":
                            button_slot11.Text = "Parked";
                            break;
                        case "12":
                            button_slot12.Text = "Parked";
                            break;
                        case "13":
                            button_slot13.Text = "Parked";
                            break;
                        case "14":
                            button_slot14.Text = "Parked";
                            break;
                        case "15":
                            button_slot15.Text = "Parked";
                            break;
                        case "16":
                            button_slot16.Text = "Parked";
                            break;
                        case "17":
                            button_slot17.Text = "Parked";
                            break;
                        case "18":
                            button_slot18.Text = "Parked";
                            break;
                        case "19":
                            button_slot19.Text = "Parked";
                            break;
                        case "20":
                            button_slot20.Text = "Parked";
                            break;
                        default:
                            break;
                    }
                }
                label_occu.Text = occupiedSpaces.ToString() + "/20";
            }
            DataRow[] dataRowsnotParked = dt_Slots.Select("isBooked = 0");
            vacantSpaces = 0;
            if (dataRowsnotParked != null)
            {
                foreach (DataRow dataRow in dataRowsnotParked)
                {
                    vacantSpaces++;
                    switch (dataRow["SlotID"].ToString())
                    {
                        case "1":
                            button_slot1.Text = "Slot 1: Vacant";
                            break;
                        case "2":
                            button_slot2.Text = "Slot 2: Vacant";
                            break;
                        case "3":
                            button_slot3.Text = "Slot 3: Vacant";
                            break;
                        case "4":
                            button_slot4.Text = "Slot 4: Vacant";
                            break;
                        case "5":
                            button_slot5.Text = "Slot 5: Vacant";
                            break;
                        case "6":
                            button_slot6.Text = "Slot 6: Vacant";
                            break;
                        case "7":
                            button_slot7.Text = "Slot 7: Vacant";
                            break;
                        case "8":
                            button_slot8.Text = "Slot 8: Vacant";
                            break;
                        case "9":
                            button_slot9.Text = "Slot 9: Vacant";
                            break;
                        case "10":
                            button_slot10.Text = "Slot 10: Vacant";
                            break;
                        case "11":
                            button_slot11.Text = "Slot 11: Vacant";
                            break;
                        case "12":
                            button_slot12.Text = "Slot 12: Vacant";
                            break;
                        case "13":
                            button_slot13.Text = "Slot 13: Vacant";
                            break;
                        case "14":
                            button_slot14.Text = "Slot 14: Vacant";
                            break;
                        case "15":
                            button_slot15.Text = "Slot 15: Vacant";
                            break;
                        case "16":
                            button_slot16.Text = "Slot 16: Vacant";
                            break;
                        case "17":
                            button_slot17.Text = "Slot 17: Vacant";
                            break;
                        case "18":
                            button_slot18.Text = "Slot 18: Vacant";
                            break;
                        case "19":
                            button_slot19.Text = "Slot 19: Vacant";
                            break;
                        case "20":
                            button_slot20.Text = "Slot 20: Vacant";
                            break;
                        default:
                            break;
                    }
                }
                label_vacantSpaces.Text = vacantSpaces.ToString() + "/20";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ParkingFees_Click(object sender, EventArgs e)
        {
            frmParkingFeesManagement parkingFees = new frmParkingFeesManagement();
            parkingFees.Show();
        }

        private void button_employeeManagement_Click(object sender, EventArgs e)
        {
            frmEmployeeManagement employeeManagement = new frmEmployeeManagement(userID);
            employeeManagement.Show();
        }

        private void button_slot1_Click(object sender, EventArgs e)
        {
            if (button_slot1.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 1")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("1","PK-001",bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-001", 1, userID);
                checkin.Show();
            }
        }

        private void button_slot2_Click(object sender, EventArgs e)
        {
            if (button_slot2.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 2")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("2", "PK-002", bookingID);
                checkout.Show();
            }
            else
            { 
                frmCheckin checkin = new frmCheckin("PK-002",2, userID);
                checkin.Show();
            }
        }

        private void button_slot3_Click(object sender, EventArgs e)
        {
            if (button_slot3.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 3")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("3", "PK-003", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-003", 3, userID);
                checkin.Show();
            }            
        }

        private void button_slot4_Click(object sender, EventArgs e)
        {
            if (button_slot4.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 4")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("4", "PK-004", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-004", 4, userID);
                checkin.Show();
            }
        }

        private void button_slot5_Click(object sender, EventArgs e)
        {
            if (button_slot5.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 5")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("5", "PK-005", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-005", 5, userID);
                checkin.Show();
            }
        }

        private void button_slot6_Click(object sender, EventArgs e)
        {
            if (button_slot6.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 6")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("6", "PK-006", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-006", 6, userID);
                checkin.Show();
            }
        }

        private void button_slot7_Click(object sender, EventArgs e)
        {
            if (button_slot7.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 7")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("7", "PK-007", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-007", 7, userID);
                checkin.Show();
            }
        }

        private void button_slot8_Click(object sender, EventArgs e)
        {
            if (button_slot8.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 8")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("8", "PK-008", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-008", 8, userID);
                checkin.Show();
            }
        }

        private void button_slot9_Click(object sender, EventArgs e)
        {
            if (button_slot9.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 9")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("9", "PK-009", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-009", 9, userID);
                checkin.Show();
            }
        }

        private void button_slot10_Click(object sender, EventArgs e)
        {
            if (button_slot10.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 10")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("10", "PK-010", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-010", 10, userID);
                checkin.Show();
            }
        }

        private void button_slot11_Click(object sender, EventArgs e)
        {
            if (button_slot11.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 11")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("11", "PK-011", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-011", 11, userID);
                checkin.Show();
            }
        }

        private void button_slot12_Click(object sender, EventArgs e)
        {
            if (button_slot12.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 12")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("12", "PK-012", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-012", 12, userID);
                checkin.Show();
            }
        }

        private void button_slot13_Click(object sender, EventArgs e)
        {
            if (button_slot13.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 13")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("13", "PK-013", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-013", 13, userID);
                checkin.Show();
            }
        }

        private void button_slot14_Click(object sender, EventArgs e)
        {
            if (button_slot14.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 14")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("14", "PK-014", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-014", 14, userID);
                checkin.Show();
            }
        }

        private void button_slot15_Click(object sender, EventArgs e)
        {
            if (button_slot15.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 15")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("15", "PK-015", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-015", 15, userID);
                checkin.Show();
            }
        }

        private void button_slot16_Click(object sender, EventArgs e)
        {
            if (button_slot16.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 16")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("16", "PK-016", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-016", 16, userID);
                checkin.Show();
            }
        }

        private void button_slot17_Click(object sender, EventArgs e)
        {
            if (button_slot17.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 17")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("17", "PK-017", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-017", 17, userID);
                checkin.Show();
            }
        }

        private void button_slot18_Click(object sender, EventArgs e)
        {
            if (button_slot18.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 18")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("18", "PK-018", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-018", 18, userID);
                checkin.Show();
            }
        }

        private void button_slot19_Click(object sender, EventArgs e)
        {
            if (button_slot19.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 19")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("19", "PK-019", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-019", 19, userID);
                checkin.Show();
            }
        }

        private void button_slot20_Click(object sender, EventArgs e)
        {
            if (button_slot20.Text == "Parked")
            {
                string bookingID = dt_Slots.Select("SlotID = 20")[0]["BookingID"].ToString();
                frmCheckout checkout = new frmCheckout("20", "PK-020", bookingID);
                checkout.Show();
            }
            else
            {
                frmCheckin checkin = new frmCheckin("PK-020", 20, userID);
                checkin.Show();
            }
        }

        private void frmParkingManager_Activated(object sender, EventArgs e)
        {
            refreshMap();
        }

        private void frmParkingManager_Enter(object sender, EventArgs e)
        {
            refreshMap();
        }

        private void frmParkingManager_MouseEnter(object sender, EventArgs e)
        {
            refreshMap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParkingManager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            carParkingHistory carParkingHistory = new carParkingHistory();
            carParkingHistory.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomersHistory customershistory = new CustomersHistory();
            customershistory.Show();
        }
    }
}
