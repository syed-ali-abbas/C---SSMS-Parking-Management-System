using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLoginForm loginForm = new frmLoginForm();
            Application.Run(loginForm);            
            if (loginForm.UserSuccessfullyAuthenticated)
            {
                string userRole = loginForm.userType;
                string username = loginForm.UserName;
                string userID = loginForm.userID;
                Application.Run(new frmParkingManager(username, userRole, userID));
            }                
        }
    }
}
