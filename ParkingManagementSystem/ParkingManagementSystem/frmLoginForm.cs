using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ParkingManagementSystem
{
    public partial class frmLoginForm : Form    
    {
        public bool UserSuccessfullyAuthenticated = false;
        public string UserName;
        public string userID;
        public string userType;
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Admin WHERE UserName = '"+ txtUserName.Text + "' and Password = '" + txtPassword.Text +"'" ;
            DataTable result = DBHandler.executeSelectQuery(query);
            string query2 = "SELECT * FROM ParkingManager WHERE UserName = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'";
            DataTable result2 = DBHandler.executeSelectQuery(query2);
            if (result.Rows.Count > 0)
            {
                DataRow dr = result.Select("")[0];
                this.userType = "Admin";
                this.UserName = dr["UserName"].ToString();
                this.userID = dr["AdminID"].ToString();
                UserSuccessfullyAuthenticated = true;
                this.Close();

            }
            else if (result2.Rows.Count > 0)
            {
                DataRow dr = result2.Select("")[0];
                this.userType = "ParkingManager";
                this.UserName = dr["ManagerName"].ToString();
                this.userID = dr["ManagerID"].ToString();
                UserSuccessfullyAuthenticated = true;
                this.Close();
            }
            {
                txtUserName.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
                this.label_result.Text = "Invalid Username or Password";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.BackColor = default;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.BackColor = default;
        }
    }
}
